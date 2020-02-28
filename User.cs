using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpfAssignment
{
    class User
    {
        private int id;
        private string name;
        private int age;
        private int score;

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public int Score
        {
            get
            {
                return score;
            }
            set
            {
                score = value;
            }
        }

        public User(string user)
        {
            var u = user.Split(';');
            Id = int.Parse(u[0]);
            Name = u[1];
            Age = int.Parse(u[2]);
            Score = int.Parse(u[3]);
        }

        public string ListBoxToString
        {
            get { 
                return $"{Name} - {Id}";
            }
        }

    }
}
