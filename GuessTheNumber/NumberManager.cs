using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace GuessTheNumber
{
    public class NumberManager
    {
        private int _userNumber;
        
        private int _secretNumber;

        private string _result;
        private bool _guessed;

        public NumberManager(int secretNumber)
        {
            _secretNumber = secretNumber;
        }

        public NumberManager TryToGuess(int userInput)
        {
            _userNumber = userInput;
            _guessed = false;
            
            CreateCompareTwoResult();

            return this;
        }

        public (bool,string) GetResult()
        {
            return CreateResult();
        }

        private void CreateCompareTwoResult()
        {
            if (_userNumber == _secretNumber)
            {
                _result = "Числа равны!";
                _guessed = true;
            }
            else
            {
                _result = _userNumber > _secretNumber ? $"Введенное число {GetDifference(_userNumber, _secretNumber)}больше!" : 
                                                        $"Введенное число {GetDifference(_secretNumber, _userNumber )}меньше!";
            }
        }

        private static string GetDifference(int first, int second)
        {
            var diff = (double)first / (double)second;

            return diff switch
            {
                >=10 => "много ",
                >=2 and <10 => "",
                <2 => "немного ",
                _ => throw new Exception("Wrong args!")
            };
        }

        private (bool, string) CreateResult()
        {
            return (_guessed, _result);
        }
    }
}