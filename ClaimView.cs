using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarshDatabase {
    interface IClaimView {
       void ShowClaimData(object sender, EventArgs e);
    }
    internal class ClaimView : TabPage,IClaimView {
        public ClaimView(DataGridView ClaimSlect) {
            Location = new System.Drawing.Point(4, 5);
            Name = "ClaimView";
            Padding = new System.Windows.Forms.Padding(3);
            Size = new System.Drawing.Size(734, 571);
            TabIndex = 0;
            Text = "ClaimView";
            UseVisualStyleBackColor = true;
        }
        public void ShowClaimData(object sender, EventArgs e) { 

        }
    }
}
