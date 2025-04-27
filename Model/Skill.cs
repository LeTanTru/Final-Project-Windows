namespace Find_Job_Management.Model {
    public class Skill {
        private int id;
        private string name;

        public Skill() {
        }
        public Skill(int id, string name) {
            this.id = id;
            this.name = name;
        }

        public int Id {
            get => id;
        }
        public string Name {
            get => name;
        }
    }
}
