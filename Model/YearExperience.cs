﻿namespace Find_Job_Management.Model {
    public class YearExperience {
        private int id;
        private string name;

        public YearExperience() {
        }
        public YearExperience(int id, string name) {
            this.id = id;
            this.name = name;
        }

        public int Id {
            get => this.id;
        }
        public string Name {
            get => this.name;
        }
    }
}
