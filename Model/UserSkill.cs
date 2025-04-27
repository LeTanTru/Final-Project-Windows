namespace Find_Job_Management.Model {
    public class UserSkill {
        private int userProfileId;
        private int skillId;
        private string name;

        public UserSkill() {
        }
        public UserSkill(int userProfileId, int skillId, string name) {
            this.userProfileId = userProfileId;
            this.skillId = skillId;
            this.name = name;
        }

        public int UserProfileId {
            get => userProfileId;
        }
        public int SkillId {
            get => skillId;
        }
        public string Name {
            get => name;
        }
    }
}
