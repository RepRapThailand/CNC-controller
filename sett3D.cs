﻿using System;
using System.Windows.Forms;

namespace CNC_Controller
{
    public partial class Sett3D : Form
    {
        MainForm mf;

        public Sett3D(MainForm _mf)
        {
            if (_mf == null) throw new ArgumentNullException("_mf");
            InitializeComponent();
            mf = _mf;
        }

        private void sett3D_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = mf.PreviewSetting.ShowInstrument;
            checkBox2.Checked = mf.PreviewSetting.ShowGrid;
            checkBox3.Checked = mf.PreviewSetting.ShowMatrix;
            checkBox4.Checked = mf.PreviewSetting.ShowAxes;
            
            numericUpDown1.Value = mf.PreviewSetting.GrigStep;

            numericUpDown2.Value=mf.PreviewSetting.GridXstart;
            numericUpDown3.Value=mf.PreviewSetting.GridXend;
            numericUpDown4.Value=mf.PreviewSetting.GridYstart;
            numericUpDown5.Value=mf.PreviewSetting.GridYend;


            checkBoxChangePos.Checked = mf.deltaUsage;
            numPosX.Value = (decimal)mf.deltaX;
            numPosY.Value = (decimal)mf.deltaY;
            numPosZ.Value = (decimal)mf.deltaZ;

            checkBox6.Checked = mf.deltaFeed;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            mf.PreviewSetting.ShowInstrument = checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            mf.PreviewSetting.ShowGrid = checkBox2.Checked;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            mf.PreviewSetting.GrigStep = (int)numericUpDown1.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            mf.PreviewSetting.GridXstart = (int)numericUpDown2.Value;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            mf.PreviewSetting.GridXend = (int)numericUpDown3.Value;

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            mf.PreviewSetting.GridYstart = (int)numericUpDown4.Value;
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            mf.PreviewSetting.GridYend = (int)numericUpDown5.Value;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

            mf.PreviewSetting.ShowMatrix = checkBox3.Checked;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            mf.PreviewSetting.ShowAxes = checkBox4.Checked;
        }

        private void numPosX_ValueChanged(object sender, EventArgs e)
        {
            mf.deltaX = (double)numPosX.Value;
        }

        private void numPosY_ValueChanged(object sender, EventArgs e)
        {
            mf.deltaY = (double)numPosY.Value;
        }

        private void numPosZ_ValueChanged(object sender, EventArgs e)
        {
            mf.deltaZ = (double)numPosZ.Value;
        }

        private void checkBoxChangePos_CheckedChanged(object sender, EventArgs e)
        {
            mf.deltaUsage = checkBoxChangePos.Checked;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            mf.deltaFeed = checkBox6.Checked;
        }


    }
}
