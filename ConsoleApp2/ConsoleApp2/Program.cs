using System;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ?";

            int L = int.Parse(Console.ReadLine());
            int H = int.Parse(Console.ReadLine());

            string T = Console.ReadLine();

            string[] letters = new string[H];
            string[] answer = new string[H];

            for (int i = 0; i < H; i++)
            {
                letters[i] = Console.ReadLine();
            }

            for (int i = 0; i < T.Length; i++)
            {
                for (int j = 0; j < H; j++)
                {
                    int index = alphabet.IndexOf(T[i]) * L;
                    string line = letters[j];
                    string letter = "";
                    for(int h =0; h < L; h++)
                    {
                        letter = letter + line[index + h];
                    }
                    answer[j] = answer[j] + letter;
                }
            }
            PrintLetters(answer);
        }
        public static void PrintLetters(string[] answer)
        {
            for (int j = 0; j < answer.Length; j++)
            {
                Console.WriteLine(answer[j]);
            }
        }
    }
}
/*
4
5 
E
 #  ##   ## ##  ### ###  ## # # ###  ## # # #   # # ###  #  ##   #  ##   ## ### # # # # # # # # # # ### ### 
# # # # #   # # #   #   #   # #  #    # # # #   ### # # # # # # # # # # #    #  # # # # # # # # # #   #   # 
### ##  #   # # ##  ##  # # ###  #    # ##  #   ### # # # # ##  # # ##   #   #  # # # # ###  #   #   #   ## 
# # # # #   # # #   #   # # # #  #  # # # # #   # # # # # # #    ## # #   #  #  # # # # ### # #  #  #       
# # ##   ## ##  ### #    ## # # ###  #  # # ### # # # #  #  #     # # # ##   #  ###  #  # # # #  #  ###  #  
### 
#   
##  
#   
### 

4
5
MANHATTAN
 #  ##   ## ##  ### ###  ## # # ###  ## # # #   # # ###  #  ##   #  ##   ## ### # # # # # # # # # # ### ### 
# # # # #   # # #   #   #   # #  #    # # # #   ### # # # # # # # # # # #    #  # # # # # # # # # #   #   # 
### ##  #   # # ##  ##  # # ###  #    # ##  #   ### # # # # ##  # # ##   #   #  # # # # ###  #   #   #   ## 
# # # # #   # # #   #   # # # #  #  # # # # #   # # # # # # #    ## # #   #  #  # # # # ### # #  #  #       
# # ##   ## ##  ### #    ## # # ###  #  # # ### # # # #  #  #     # # # ##   #  ###  #  # # # #  #  ###  #  

# #  #  ### # #  #  ### ###  #  ###  
### # # # # # # # #  #   #  # # # #  
### ### # # ### ###  #   #  ### # #  
# # # # # # # # # #  #   #  # # # #  
# # # # # # # # # #  #   #  # # # #     

*/