using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prac_dgv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        CParentGroup _PGroup { get; set; }
        List<CParent> _SelectParent { get; set; }
        List<CChild> _SelectChild { get; set; }

        int _Pidx = 0;  // 부모 네이밍 인덱스

        private void Form1_Load(object sender, EventArgs e)
        {
            _PGroup = new CParentGroup();

            _SelectParent = new List<CParent>();    // 인덱스 0 : 마지막 선택
            _SelectChild = new List<CChild>();
        }

        /// <summary>
        /// 부모 추가 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPAdd_Click(object sender, EventArgs e)
        {
            CParent newParent = new CParent(string.Format("부모 {0}", ++_Pidx));
            for (int i = 0; i < 3; i++)
            {
                newParent.CList.Add(new CChild(string.Format("{0} - 자식 {1}", newParent.Name, i)));
            }

            // 원본 리스트에 추가
            _PGroup.PList.Add(newParent);

            // 부모 리스트 업데이트
            UpdateParent();

            // 추가한 부모 포커스 설정
            dgvParent.CurrentCell = dgvParent.Rows[dgvParent.RowCount - 1].Cells[1];

            // 선택한 부모에 맞춰 자식 리스트 업데이트
            UpdateChild();
        }
        /// <summary>
        /// 부모 병합 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPMerge_Click(object sender, EventArgs e)
        {
            CParent mainP = dgvParent.SelectedRows[dgvParent.SelectedRows.Count - 1].Tag as CParent;

            foreach (CParent cp in dgvParent.SelectedRows)
            {
                if (cp != mainP)
                {
                    mainP.CList.AddRange(cp.CList);
                    _PGroup.PList.Remove(cp);
                }
            }
            // 부모 리스트 업데이트
            UpdateParent();

            // mainP에 포커스 맞추기
            foreach (DataGridViewRow row in dgvParent.Rows)
            {
                if (row.Tag == mainP)
                {
                    dgvParent.CurrentCell = dgvParent.Rows[row.Index].Cells[1];
                }
            }
        }
        /// <summary>
        /// 부모 삭제 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPDel_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow cp in dgvParent.SelectedRows)
            {
                _PGroup.PList.Remove((CParent)cp.Tag);
            }
            // 부모 리스트 업데이트
            UpdateParent();
            dgvParent.CurrentCell = dgvParent.Rows[0].Cells[1];
        }

        /// <summary>
        /// 자식 추가 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCAdd_Click(object sender, EventArgs e)
        {
            if (dgvParent.SelectedRows.Count < 1)
            {
                MessageBox.Show("부모를 선택하세요.");
                return;
            }
            if (dgvParent.SelectedRows.Count > 1)
            {
                MessageBox.Show("부모를 하나만 선택하세요.");
                return;
            }

            _SelectParent[0].CList.Add(new CChild("자식 추가"));

            DisplayParent();    // 선택한 부모 count 업데이트
            UpdateChild();
        }
        /// <summary>
        /// 자식 분리 버튼 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCSep_Click(object sender, EventArgs e)
        {
            if (dgvParent.SelectedRows.Count != 1)
            {
                MessageBox.Show("부모를 하나만 선택하세요.");
                return;
            }

            CParent cp = new CParent(string.Format("분리 (from {0})", dgvParent.SelectedRows[0].Cells[2].Value.ToString()));
            foreach (CChild cc in _SelectChild)
            {
                cp.CList.Add(cc);
                _PGroup.PList[dgvParent.SelectedRows[0].Index].CList.Remove(cc);
            }
            // 새로운 부모 추가
            _PGroup.PList.Add(cp);
            
            // 부모 리스트 업데이트
            UpdateParent();
           
            // 새로운 부모에 포커싱
            dgvParent.CurrentCell = dgvParent.Rows[dgvParent.RowCount - 1].Cells[1];
            
            // 자식 리스트 업데이트
            UpdateChild();
        }
        /// <summary>
        /// 자식 삭제 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCDel_Click(object sender, EventArgs e)
        {
            if (dgvParent.SelectedRows.Count != 1)
            {
                MessageBox.Show("부모를 하나만 선택하세요.");
                return;
            }
            if (dgvChild.SelectedRows.Count == dgvChild.RowCount)
            {
                MessageBox.Show("모두 삭제하려면\n부모 삭제를 이용해야 합니다.");
                return;
            }

            foreach (CChild cc in _SelectChild)
            {
                _PGroup.PList[dgvParent.SelectedRows[0].Index].CList.Remove(cc);
            }
            // 부모 리스트 Count 업데이트
            DisplayParent();

            // 자식 리스트 업데이트
            UpdateChild();
        }


        #region -- Select --
        /// <summary>
        /// 부모 리스트 Select
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvParent_Select(object sender = null, EventArgs e = null)
        {
            // _SelectParent 초기화 후 추가
            _SelectParent.Clear();
            foreach (DataGridViewRow row in dgvParent.SelectedRows)
            {
                _SelectParent.Add((CParent)row.Tag);
            }

            // 선택 부모 있으면 자식 리스트 업데이트
            if (_SelectParent.Count != 0 && _SelectParent[0] != null)
            {
                UpdateChild();
            }
        }

        /// <summary>
        /// 자식 리스트 Select
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvChild_Select(object sender = null, EventArgs e = null)
        {
            // _SelectChild 초기화 후 추가
            _SelectChild.Clear();
            foreach (DataGridViewRow row in dgvChild.SelectedRows)
            {
                _SelectChild.Add((CChild)row.Tag);
            }
        }
        #endregion

        #region -- Update, Display --
        /// <summary>
        /// 부모 리스트 초기화 후 업데이트
        /// </summary>
        private void UpdateParent()
        {
            dgvParent.Rows.Clear();
            foreach (CParent cp in _PGroup.PList)
            {
                dgvParent.Rows.Add(cp);
                dgvParent.Rows[dgvParent.RowCount - 1].Tag = cp;
            }
            DisplayParent();
        }
        /// <summary>
        /// 자식 리스트 초기화 후 업데이트
        /// </summary>
        private void UpdateChild()
        {
            if (_SelectParent.Count != 0 && _SelectParent[0] != null)   // 부모가 선택되어있는지 확인
            {
                dgvChild.Rows.Clear();
                foreach (CChild cc in _SelectParent[0].CList)
                {
                    dgvChild.Rows.Add(cc);
                    dgvChild.Rows[dgvChild.RowCount - 1].Tag = cc;
                }
                DisplayChild();
            }
        }

        private void DisplayParent()
        {
            lblParent.Text = string.Format("부모 리스트 ({0})", dgvParent.RowCount);

            int i = 0;
            foreach (DataGridViewRow row in dgvParent.Rows)
            {
                CParent cp = row.Tag as CParent;

                row.Cells[0].Value = ++i;
                row.Cells[1].Value = cp.IsSelect;
                row.Cells[2].Value = cp.Name;
                row.Cells[3].Value = cp.CList.Count;
            }
        }

        private void DisplayChild()
        {
            lblChild.Text = string.Format("자식 리스트 ({0})", dgvChild.RowCount);

            int i = 0;
            foreach (DataGridViewRow row in dgvChild.Rows)
            {
                CChild cc = row.Tag as CChild;

                row.Cells[0].Value = ++i;
                row.Cells[1].Value = cc.IsSelect;
                row.Cells[2].Value = cc.Name;
            }
        }
        #endregion

    }
}
