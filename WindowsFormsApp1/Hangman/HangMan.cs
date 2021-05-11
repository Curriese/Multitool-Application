using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultiToolApplication
{
    class HangMan
    {
        //The word to be Guessed
        private String word;
        //Amount of wrong guesses
        private int wrongGuesses;
        //Containing all words
        private Dictionary<int, String> allWords = new Dictionary<int, string>();


        /// <summary>
        /// Default Constructor 
        /// </summary>
        public HangMan()
        {
            AddWordsToDict();
            wrongGuesses = 0;
        }

        /// <summary>
        /// Resets the game to the default values
        /// </summary>
        public void Reset()
        {
            word = PickWord();
            wrongGuesses = 0;
            Console.WriteLine("The Word is " + word);
        }
              
        /// <summary>
        /// Selects a random word from the dictionary and makes it the word to guess
        /// </summary>
        /// <returns></returns>
        public String PickWord()
        {
            Random r = new Random();
            int randomInt = r.Next(0, allWords.Count());
            String result;
            allWords.TryGetValue(randomInt, out result);
            return result;
        }

        /// <summary>
        /// Determines if the game is over with a loss
        /// </summary>
        /// <returns> Returns a 0 if you lose a 2 otherwise</returns>
        public int CheckVictory()
        {
            if(wrongGuesses == 6)
            {
                //You lose
                return 0;
            }
            else
            {
                //You don't lose
                return 2;
            }
        }


        /// <summary>
        /// Helper method to get words from txt file into the dictionary
        /// </summary>
        public void AddWordsToDict()
        {
            try
            {
                System.IO.StreamReader file = new System.IO.StreamReader("C:\\Users\\Spenser\\source\\repos\\WindowsFormsApp1\\WindowsFormsApp1\\HangMan\\HangManWords.txt");
                wrongGuesses = 0;
                //Change greater than number to length of dictionary for new words
                for (int i = 0; i < 214; i++)
                {
                    allWords.Add(i, file.ReadLine());
                }
            } 
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Checks if the given letter is in the word to guess. Determines what location each position the letter
        /// is in.
        /// </summary>
        /// <param name="letter"> The letter that will be chcked with</param>
        /// <returns>Positions of given letter in the word </returns>
        public ArrayList CheckLetterInWord(char letter)
        {
            ArrayList locations = new ArrayList();
            int size = word.Length;
            StringBuilder wordCopy = new StringBuilder(word);

            if (word.Contains(letter))
            {
                for(int i = 0; i < size; i++)
                {
                    if(wordCopy[0] == letter)
                    {
                        locations.Add(i);
                        wordCopy.Remove(0, 1);
                    }
                    else
                    {
                        wordCopy.Remove(0, 1);
                    }
                }
            }
            else
            {
                AddWrongGuessed();
            }
            return locations;
        }


        /// <summary>
        /// Getter for wrongGuesses variable
        /// </summary>
        /// <returns></returns>
        public int GetWrongGuesses()
        {
            return wrongGuesses;
        }

        /// <summary>
        /// Getter for word length
        /// </summary>
        /// <returns> word length </returns>
        public int GetWordCount()
        {
            return word.Length;
        }

        /// <summary>
        /// Getter for the word
        /// </summary>
        /// <returns> The word to be guessed </returns>
        public String GetWord()
        {
            return word;
        }

        /// <summary>
        /// Adds 1 to wrong guess count
        /// </summary>
        public void AddWrongGuessed()
        {
            wrongGuesses += 1;
        }

    }
}
