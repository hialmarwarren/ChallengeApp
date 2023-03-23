﻿namespace ChallengeApp;
    internal class Employee
    {
        private List<int> score = new List<int>();
        public Employee(int number, string name, string surname, int age)
        {
            this.UserId = number;
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
        public int UserId { get; private set; }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
        public void AddScore(int score)
        {
            this.score.Add(score);
        }
        public int Result
        {
            get
            {
                return this.score.Sum();
            }
        }
    }
