using System.Drawing;
using System.Windows.Forms;

namespace Find_Job_Management.Utils {
    public enum DialogBoxType {
        Error,
        Warning,
        Success,
    }
    public partial class DialogBox : Form {
        public DialogBox() {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.lblMessage.TextAlign = ContentAlignment.MiddleCenter;
        }

        public static void Show(Form parentForm, DialogBoxType type, string title, string message) {

        }
    }
}
