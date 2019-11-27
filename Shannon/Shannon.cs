using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shannon
{
    public class Shannon

    {
        int sum ;
        String[] lastBitsRemained;
        public int counter =0;
        public byte[] contentOfBytes;
        public Dictionary<byte, string> finalList2 = new Dictionary<byte, string>();
        public Dictionary<byte,int> finalDictionarySorted ;
        public Dictionary<byte, int> finalDictionarySorted1;
        public List<Tuple<byte, int, int>> finalDictionarySortedSum;
        public Dictionary<byte, string> finalList= new Dictionary<byte, string>();
        public Dictionary<byte, int> frequenciesNotSorted ;
        public Dictionary<byte, int> frequenciesNotSorted1;
        public Dictionary<byte, string>finalList1;
        BitWriter bitWriter;
        BitReader bitReader;
        public List<Tuple<byte, int>> frequenciesNotSortedTest;
        public List<Tuple<byte, int>> frequenciesNotSortedTest1;
        public List<Tuple<byte, string>> flux = new List<Tuple<byte, string>>();

        public List<Tuple<byte, string,int>> fluxFinal = new List<Tuple<byte, string,int>>();
        public Shannon(byte[] contentOfBytes)
        {
            this.contentOfBytes = contentOfBytes;
        }
        public void DecodeShannon(string filepath)
        {
            string filePathIn = @"E:\FACULTATE\an 4\Sem1_Mine\output16.txt";

            BitWriter bitWriter2 = new BitWriter(filePathIn);
            finalDictionarySortedSum.Clear();
            finalList.Clear();
            frequenciesNotSortedTest.Clear();
            string filePathOutput = @"E:\FACULTATE\an 4\Sem1_Mine\output13.txt";
            ReadFrequency(filePathOutput, out finalDictionarySorted1,out lastBitsRemained,out sum);
            CalculateFrequency(contentOfBytes, out finalDictionarySorted1, out frequenciesNotSortedTest);
            CalculateSumDependingOnFrequency(finalDictionarySorted1, out finalDictionarySortedSum);

            ShannonTree(0, finalDictionarySortedSum, "");
            string content = "";

           foreach (KeyValuePair<byte, int> unmodifiedFlux in finalDictionarySorted1)
            {
                foreach (KeyValuePair<byte, string> pair in finalList)
                {
                    if (unmodifiedFlux.Key == pair.Key)
                    {
                        fluxFinal.Add(Tuple.Create(pair.Key, pair.Value, unmodifiedFlux.Value));
                    }


                }

            }
            do {
                foreach (Tuple<byte, string,int> modifiedFlux in fluxFinal)
                {
                    for (int i = 0; i < lastBitsRemained.Length; i++)
                    {
                        content += lastBitsRemained[i];
                        if (content == modifiedFlux.Item2)
                        {
                            bitWriter2.WriteNBits(8,Convert.ToInt16(modifiedFlux.Item1));

                            sum -= modifiedFlux.Item3;
                            content = "";
                            var list = lastBitsRemained.ToList();
                            for (int j = 0; j <= i; j++)
                            {
                                list.RemoveAt(i);
                               
                            }
                            lastBitsRemained = list.ToArray();
                        }
                }
                }

            } while (sum>0);
            


        }

        
        public bool EncodeShannon(byte[] contentOfBytes,out Dictionary<byte,string>finalList1 )
        {
            string filePathOutput = @"E:\FACULTATE\an 4\Sem1_Mine\output13.txt";

            bitWriter = new BitWriter(filePathOutput);

            this.contentOfBytes = contentOfBytes;
            finalList1 = new Dictionary<byte, string>();
            CalculateFrequency(contentOfBytes, out finalDictionarySorted,out frequenciesNotSortedTest);
            CalculateSumDependingOnFrequency(finalDictionarySorted, out finalDictionarySortedSum);
            WriteHeader(contentOfBytes);
          
            finalList1 = finalList;

            ShannonTree(0, finalDictionarySortedSum, "");
            finalList2 = finalList1;
            foreach (Tuple<byte, int> unmodifiedFlux in frequenciesNotSortedTest)
            {
                foreach (KeyValuePair<byte, string> pair in finalList1)
                {
                    if (unmodifiedFlux.Item1 == pair.Key)
                    {
                        flux.Add(Tuple.Create(pair.Key,pair.Value));
                    }


                }

            }
            foreach (Tuple<byte, string> pair in flux)
            {
                string s = pair.Item2;
                for (var i = 0; i < s.Length; i++)
                {
                    if (s[i] == '0')
                    {
                        bitWriter.WriteNBits(1, 0);
                    }
                    else
                    {
                        bitWriter.WriteNBits(1, 1);
                    }
                }
            }

            bitWriter.WriteNBits(7, 0xfF);
          
             bitWriter.Dispose();

         
           DecodeShannon(filePathOutput);
            
            return true;
            

        }
        public bool ReadFrequency(string filePathOutput, out Dictionary<byte, int> finalDictionarySorted1,out String[] lastBitsRemained,out int sum)
        {
            Int32[] counterFinal = new Int32[256];
            Int32[] counterFinal1 = new Int32[256];
           
          
            finalDictionarySorted1 = new Dictionary<byte, int>();
            bitReader = new BitReader(filePathOutput);
            long NBR = 0;
            var fileSize = new FileInfo(filePathOutput).Length;
            NBR = 8 * fileSize;
           
                for (int i = 0; i < 256; i++)
                {
                    int a = bitReader.ReadNBits(2);
                    if (a == 0)
                    {
                        counterFinal[i] = 0;
                    }
                    else if (a == 1)
                    {
                        counterFinal[i] = 8;
                    }
                    else if (a == 2)
                    {
                        counterFinal[i] = 16;
                    }
                    else if (a == 3)
                    {
                        counterFinal[i] = 32;
                    }

                }
                int bytesRead = 512;
               sum = 0;
                for (int i = 0; i < 256; i++)
                {
                    int ciit = counterFinal[i];
                    if (ciit > 0)
                    {

                        counterFinal1[i] = (int)bitReader.ReadNBits(ciit);
                        finalDictionarySorted1.Add((byte)i, counterFinal1[i]);
                        bytesRead += ciit;
                       sum += counterFinal1[i];
                    }
                }
            
              NBR -= bytesRead;
             lastBitsRemained = new String[(int)NBR];
           
            for (int j = 0; j < (int)NBR; j++)
            {

                int value = bitReader.ReadNBits(1);
                lastBitsRemained[j] += Convert.ToString(value);
            
            }
            return true;

        }
        public void WriteHeader(byte[] contentOfBytes)
        {
            Int32[] counterFinal = new Int32[256];

            for (int i = 0; i < contentOfBytes.Length; i++)
            {
                counterFinal[contentOfBytes[i]]++;

            }

            for (int i = 0; i < counterFinal.Length; i++)
            {

                if (counterFinal[i] == 0)
                {
                    bitWriter.WriteNBits(2, 0);
                }
                else if (counterFinal[i] < Math.Pow(2, 8))
                {
                    bitWriter.WriteNBits(2, 1);
                }
                else if (counterFinal[i] >= Math.Pow(2, 8) && counterFinal[i] < Math.Pow(2, 16))
                {
                    bitWriter.WriteNBits(2, 2);
                }
                else if (counterFinal[i] >= Math.Pow(2, 8) && counterFinal[i] >= Math.Pow(2, 16) && counterFinal[i] < Math.Pow(2, 32))
                {
                    bitWriter.WriteNBits(2, 3);
                }


            }
            for (int i = 0; i < counterFinal.Length; i++)
            {
                if (counterFinal[i] > 0)
                {
                    if (counterFinal[i] < Math.Pow(2, 8))
                    {

                        bitWriter.WriteNBits(8, counterFinal[i]);
                    }
                    else if (counterFinal[i] >= Math.Pow(2, 8) && counterFinal[i] < Math.Pow(2, 16))
                    {
                        bitWriter.WriteNBits(16, counterFinal[i]);
                    }
                    else if (counterFinal[i] >= Math.Pow(2, 8) && counterFinal[i] >= Math.Pow(2, 16) && counterFinal[i] < Math.Pow(2, 32))
                    {
                        bitWriter.WriteNBits(32, contentOfBytes[i]);
                    }

                }
            }
        

        }
        public bool CalculateFrequency(byte[] contentOfBytes, out Dictionary<byte, int> finalDictionarySorted,  out List<Tuple<byte, int>> frequenciesNotSortedTest)
        {
            Int32[] counterFinal = new Int32[256];
            frequenciesNotSorted = new Dictionary<byte, int>();
            frequenciesNotSortedTest = new List<Tuple<byte, int>>();
            for (int i = 0; i < contentOfBytes.Length; i++)
            {
                counterFinal[contentOfBytes[i]]++;
                
            }
            for (int i = 0; i < contentOfBytes.Length;   i++)
            {
                frequenciesNotSortedTest.Add(Tuple.Create(contentOfBytes[i], counterFinal[contentOfBytes[i]]));
            }

            for (int i = 0; i < contentOfBytes.Length; i++)
            {

                if (counterFinal[contentOfBytes[i]] != -1)
                {
                    frequenciesNotSorted.Add(contentOfBytes[i], counterFinal[contentOfBytes[i]]);
                    counterFinal[contentOfBytes[i]] = -1;
                }

            }


                finalDictionarySorted = frequenciesNotSorted.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            
                return true;

            }
        public bool CalculateSumDependingOnFrequency(Dictionary<byte, int> finalDictionarySorted, out List<Tuple<byte, int, int>> finalDictionarySortedSum)
        {

            finalDictionarySortedSum = new List<Tuple<byte, int, int>>();
            int sum;
            int itemsToSkip = 1;
            int temporarValue = 0;
            foreach (KeyValuePair<byte, int> temp in finalDictionarySorted)
            {
                sum = 0;
                temporarValue += temp.Value;
                sum = sum + finalDictionarySorted.Skip(itemsToSkip).Sum(v => v.Value);
                sum = temporarValue - sum;
                sum = Math.Abs(sum);
                finalDictionarySortedSum.Add(Tuple.Create(temp.Key,temp.Value,sum));
                itemsToSkip++;
            }
            counter = itemsToSkip - 1;

            return true;
        }

       
        public void ShannonTree(int counter,  List<Tuple<byte, int, int>> finalDictionarySortedSum ,string symbol)
        {

            var minimum = 0;
            if (counter == 0 && finalDictionarySortedSum.Count()==1 && symbol =="")
            {
                finalList.Add(finalDictionarySortedSum.First().Item1, symbol+"0");
                return;
            }
            if (finalDictionarySortedSum.Count() == 1)
            {
                finalList.Add(finalDictionarySortedSum.First().Item1,symbol);
             
                return ;
            }
            
            else
            {
                Dictionary<byte, int> finalDictionarySortedSumTemp = finalDictionarySortedSum.ToDictionary(l => l.Item1, l => l.Item2);
                CalculateSumDependingOnFrequency(finalDictionarySortedSumTemp, out finalDictionarySortedSum);
                minimum = finalDictionarySortedSum.Min(x => x.Item3);
                int index = finalDictionarySortedSum.FindIndex(t => t.Item3 == minimum);
                List<Tuple<byte,int,int>> leftSide = finalDictionarySortedSum.Take(index + 1).ToList();
                List<Tuple<byte, int, int>> rightSide = finalDictionarySortedSum.Skip(index + 1).ToList();
                ShannonTree(counter + 1, leftSide, symbol + "0");
                ShannonTree(counter + 1, rightSide, symbol + "1");

            }
        
        }
    }
}
