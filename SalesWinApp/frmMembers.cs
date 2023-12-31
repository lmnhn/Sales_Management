﻿using BusinessObject.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmMembers : Form
    {
        private IMemberRepository memberRepository;
        BindingSource source;
        bool InsertOrUpdate = true;
        public frmMembers()
        {
            InitializeComponent();
        }

        private void GetMembersList(string search = "")
        {
            memberRepository = new MemberRepository();
            IEnumerable<Member> members = memberRepository.GetMembers().Where(s => s.City.Contains(search) || s.Country.Contains(search));
            foreach (Member member in members)
            {
                member.Password = "**********"; // Hide the password
            }
            source = new BindingSource();
            source.DataSource = members;
            dgvMemberDetail.DataSource = null;
            dgvMemberDetail.DataSource = source;
           
        }

        private void frmMembers_Load(object sender, EventArgs e)
        {
            GetMembersList();
        }



        private void Quit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var member = memberRepository.GetMembers().ToList()[dgvMemberDetail.CurrentRow.Index];

            if (member != null)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to remove this member?", "Confirm Member Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    memberRepository.Delete(member);
                    GetMembersList();
                }
            }
            else
            {
                MessageBox.Show("Member not found", "Remove Member", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            InsertOrUpdate = true;
            frmMembersDetail frmMembersDetail = new frmMembersDetail()
            {
                Text = "Create Member",
                _MemberRepository = memberRepository,
                _InsertOrUpdate = InsertOrUpdate
            };
            if (frmMembersDetail.ShowDialog() == DialogResult.OK)
            {
                GetMembersList();
                source.Position = source.Count - 1;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var member = memberRepository.GetMembers().ToList()[dgvMemberDetail.CurrentRow.Index];
            InsertOrUpdate = false;
            if (member != null)
            {
                frmMembersDetail frmMembersDetail = new frmMembersDetail()
                {
                    Text = "Update Member",
                    _MemberRepository = memberRepository,
                    _InsertOrUpdate = InsertOrUpdate,
                    MemberDetail = member
                };
                if (frmMembersDetail.ShowDialog() == DialogResult.OK)
                {
                    GetMembersList();
                }
            }
            else
            {
                MessageBox.Show("Not found member", "Update Member", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void dgvMemberDetail_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var member = memberRepository.GetMembers().ToList()[dgvMemberDetail.CurrentRow.Index];
            InsertOrUpdate = false;
            if (member != null)
            {
                frmMembersDetail frmMembersDetail = new frmMembersDetail()
                {
                    Text = "Update Member",
                    _MemberRepository = memberRepository,
                    _InsertOrUpdate = InsertOrUpdate,
                    MemberDetail = member
                };
                if (frmMembersDetail.ShowDialog() == DialogResult.OK)
                {
                    GetMembersList();
                }
            }
            else
            {
                MessageBox.Show("Not found member", "Update Member", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;
            GetMembersList(keyword);
        }
    }
}
