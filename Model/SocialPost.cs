using System;
using System.Collections.Generic;

namespace Find_Job_Management.Model {
    public class SocialPost {
        private int id;
        private string title;
        private DateTime postDate;
        private string contents;
        private int accountId;
        private List<Skill> skills;
        public SocialPost() {
            skills = new List<Skill>();
        }

        public SocialPost(int id, string title, DateTime postDate, string contents, int accountId) : this() {
            this.id = id;
            this.title = title;
            this.postDate = postDate;
            this.contents = contents;
            this.accountId = accountId;
        }
        public SocialPost(string title, DateTime postDate, string contents, int accountId, List<Skill> skills) : this() {
            this.title = title;
            this.postDate = postDate;
            this.contents = contents;
            this.accountId = accountId;
            this.skills = skills;
        }

        public int Id {
            get => id;
        }
        public string Title {
            get => title;
        }
        public DateTime PostDate {
            get => postDate;
        }
        public string Contents {
            get => contents;
        }
        public int AccountId {
            get => accountId;
        }
        public List<Skill> Skills {
            get => skills;
        }
    }
}
