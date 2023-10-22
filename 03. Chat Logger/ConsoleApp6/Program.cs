using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main()
        {
            List<string> chetHistor = new List<string>();




            while (true)
            {
                string cammmand = Console.ReadLine();

                if (cammmand == "end")
                    break;



                string[] cammmandParts = cammmand.Split();

                if (cammmandParts[0] == "Chat")
                {
                    string message = string.Join(" ", cammmandParts, 1, cammmandParts.Length - 1);
                    chetHistor.Add(message);
                }
                else if (cammmandParts[0] == "Delete")
                {
                    string message = string.Join(" ", cammmandParts, 1, cammmandParts.Length - 1);
                    if (chetHistor.Contains(message))
                        chetHistor.Remove(message);
                }
                else if (cammmandParts[0] == "Edit")
                {
                    string message = string.Join(" ", cammmandParts, 1, 1);
                    string editedMessage = string.Join(" ", cammmandParts, 2, cammmandParts.Length - 2);
                    int index = chetHistor.IndexOf(message);
                    if (index != -1)
                        chetHistor[index] = editedMessage;
                }
                else if (cammmandParts[0] == "Pin")
                {
                    string message = string.Join(" ", cammmandParts, 1, cammmandParts.Length - 1);
                    if (chetHistor.Contains(message))
                    {
                        chetHistor.Remove(message);
                        chetHistor.Add(message);
                    }


                }
                else if (cammmandParts[0] == "Spam")
                {
                    for (int i = 1; i < cammmandParts.Length; i++)
                    {
                        chetHistor.Add(cammmandParts[i]);
                    }
                }
            }





            foreach (string message in chetHistor)
            {
                Console.WriteLine(message);
            }
        }
    }
}
