using System;
using System.Collections.Generic;

namespace ScrabbleScorer.Models
{
    public class MyScrabbleScorer
    {
        public string Word { get; set; } = "bola";

        // public MyScrabbleScorer(string myWord)
        // {
        //     Word = myWord;
        // }
        
        // public int ScrabbleScoreDeterminer()
        // {
        //     string wordsCap = Word.ToUpper();
        //     char[] theCharArray = wordsCap.ToCharArray();

        //     int totalScore = 0;           
        //     foreach (char item in theCharArray)
        //     {
        //         switch (item)
        //         {
        //             case 'A':
        //             case 'E':
        //             case 'I':
        //             case 'O':
        //             case 'U':
        //             case 'L':
        //             case 'N':
        //             case 'R':
        //             case 'S':
        //             case 'T':
        //                 totalScore += 1;
        //                 break;

        //             case 'D':
        //             case 'G':
        //                 totalScore += 2;
        //                 break;

        //             case 'B':
        //             case 'C':
        //             case 'M':
        //             case 'P':
        //                 totalScore += 3;
        //                 break;

        //             case 'F':
        //             case 'H':
        //             case 'V':
        //             case 'W':
        //             case 'Y':
        //                 totalScore += 4;
        //                 break;

        //             case 'K':
        //                     totalScore += 5;
        //             break;  
                       
        //             case 'J':
        //             case 'X':
        //                     totalScore += 8;
        //                 break;  
                        
        //             case 'Q':
        //             case 'Z':
        //                     totalScore += 10;
        //                 break;  

        //         }
                
        //     }
        //     return totalScore;
        // }
        
    }
}