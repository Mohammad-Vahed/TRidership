using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace SCRNAseq
{

    public partial class About : Page
    {

        protected void Button2_Click(object sender, EventArgs e)
        {
            main();
            
        }
        public void main()
        {
            TextBox442.Text = "";
            TextBox443.Text = "";

            int[,] mat = new int[20, 20];
            int[,] temp = new int[20, 20];
            int[] bus = new int[20];
            int[] sumrow = new int[20];
            int[] sumcol = new int[20];
            int i, j, x = 0, y = 0, k = 0, l = 0, m;
            string skip;
            int[] skipped = new int[20];
            int[] skippedsec = new int[20];
            int max = int.Parse(DropDownList41.SelectedValue.ToString());
            int value = int.Parse(TextBox444.Text);


            for (i = 0; i < 20; i++)
            {
                sumrow[i] = 0;
                sumcol[i] = 0;
                skipped[i] = 0;
                bus[i] = 0;
            }

            mat[0, 0] = int.Parse(TextBox21.Text); mat[0, 1] = int.Parse(TextBox22.Text); mat[0, 2] = int.Parse(TextBox23.Text); mat[0, 3] = int.Parse(TextBox24.Text); mat[0, 4] = int.Parse(TextBox25.Text); mat[0, 5] = int.Parse(TextBox26.Text); mat[0, 6] = int.Parse(TextBox27.Text); mat[0, 7] = int.Parse(TextBox28.Text); mat[0, 8] = int.Parse(TextBox29.Text); mat[0, 9] = int.Parse(TextBox30.Text);
            mat[0, 10] = int.Parse(TextBox31.Text); mat[0, 11] = int.Parse(TextBox32.Text); mat[0, 12] = int.Parse(TextBox33.Text); mat[0, 13] = int.Parse(TextBox34.Text); mat[0, 14] = int.Parse(TextBox35.Text); mat[0, 15] = int.Parse(TextBox36.Text); mat[0, 16] = int.Parse(TextBox37.Text); mat[0, 17] = int.Parse(TextBox38.Text); mat[0, 18] = int.Parse(TextBox39.Text); mat[0, 19] = int.Parse(TextBox40.Text);

            mat[1, 0] = int.Parse(TextBox41.Text); mat[1, 1] = int.Parse(TextBox42.Text); mat[1, 2] = int.Parse(TextBox43.Text); mat[1, 3] = int.Parse(TextBox44.Text); mat[1, 4] = int.Parse(TextBox45.Text); mat[1, 5] = int.Parse(TextBox46.Text); mat[1, 6] = int.Parse(TextBox47.Text); mat[1, 7] = int.Parse(TextBox48.Text); mat[1, 8] = int.Parse(TextBox49.Text); mat[1, 9] = int.Parse(TextBox50.Text);
            mat[1, 10] = int.Parse(TextBox51.Text); mat[1, 11] = int.Parse(TextBox52.Text); mat[1, 12] = int.Parse(TextBox53.Text); mat[1, 13] = int.Parse(TextBox54.Text); mat[1, 14] = int.Parse(TextBox55.Text); mat[1, 15] = int.Parse(TextBox56.Text); mat[1, 16] = int.Parse(TextBox57.Text); mat[1, 17] = int.Parse(TextBox58.Text); mat[1, 18] = int.Parse(TextBox59.Text); mat[1, 19] = int.Parse(TextBox60.Text);

            mat[2, 0] = int.Parse(TextBox61.Text); mat[2, 1] = int.Parse(TextBox62.Text); mat[2, 2] = int.Parse(TextBox63.Text); mat[2, 3] = int.Parse(TextBox64.Text); mat[2, 4] = int.Parse(TextBox65.Text); mat[2, 5] = int.Parse(TextBox66.Text); mat[2, 6] = int.Parse(TextBox67.Text); mat[2, 7] = int.Parse(TextBox68.Text); mat[2, 8] = int.Parse(TextBox69.Text); mat[2, 9] = int.Parse(TextBox70.Text);
            mat[2, 10] = int.Parse(TextBox71.Text); mat[2, 11] = int.Parse(TextBox72.Text); mat[2, 12] = int.Parse(TextBox73.Text); mat[2, 13] = int.Parse(TextBox74.Text); mat[2, 14] = int.Parse(TextBox75.Text); mat[2, 15] = int.Parse(TextBox76.Text); mat[2, 16] = int.Parse(TextBox77.Text); mat[2, 17] = int.Parse(TextBox78.Text); mat[2, 18] = int.Parse(TextBox79.Text); mat[2, 19] = int.Parse(TextBox80.Text);

            mat[3, 0] = int.Parse(TextBox81.Text); mat[3, 1] = int.Parse(TextBox82.Text); mat[3, 2] = int.Parse(TextBox83.Text); mat[3, 3] = int.Parse(TextBox84.Text); mat[3, 4] = int.Parse(TextBox85.Text); mat[3, 5] = int.Parse(TextBox86.Text); mat[3, 6] = int.Parse(TextBox87.Text); mat[3, 7] = int.Parse(TextBox88.Text); mat[3, 8] = int.Parse(TextBox89.Text); mat[3, 9] = int.Parse(TextBox90.Text);
            mat[3, 10] = int.Parse(TextBox91.Text); mat[3, 11] = int.Parse(TextBox92.Text); mat[3, 12] = int.Parse(TextBox93.Text); mat[3, 13] = int.Parse(TextBox94.Text); mat[3, 14] = int.Parse(TextBox95.Text); mat[3, 15] = int.Parse(TextBox96.Text); mat[3, 16] = int.Parse(TextBox97.Text); mat[3, 17] = int.Parse(TextBox98.Text); mat[3, 18] = int.Parse(TextBox99.Text); mat[3, 19] = int.Parse(TextBox100.Text);

            mat[4, 0] = int.Parse(TextBox101.Text); mat[4, 1] = int.Parse(TextBox102.Text); mat[4, 2] = int.Parse(TextBox103.Text); mat[4, 3] = int.Parse(TextBox104.Text); mat[4, 4] = int.Parse(TextBox105.Text); mat[4, 5] = int.Parse(TextBox106.Text); mat[4, 6] = int.Parse(TextBox107.Text); mat[4, 7] = int.Parse(TextBox108.Text); mat[4, 8] = int.Parse(TextBox109.Text); mat[4, 9] = int.Parse(TextBox110.Text);
            mat[4, 10] = int.Parse(TextBox111.Text); mat[4, 11] = int.Parse(TextBox112.Text); mat[4, 12] = int.Parse(TextBox113.Text); mat[4, 13] = int.Parse(TextBox114.Text); mat[4, 14] = int.Parse(TextBox115.Text); mat[4, 15] = int.Parse(TextBox116.Text); mat[4, 16] = int.Parse(TextBox117.Text); mat[4, 17] = int.Parse(TextBox118.Text); mat[4, 18] = int.Parse(TextBox119.Text); mat[4, 19] = int.Parse(TextBox120.Text);

            mat[5, 0] = int.Parse(TextBox121.Text); mat[5, 1] = int.Parse(TextBox122.Text); mat[5, 2] = int.Parse(TextBox123.Text); mat[5, 3] = int.Parse(TextBox124.Text); mat[5, 4] = int.Parse(TextBox125.Text); mat[5, 5] = int.Parse(TextBox126.Text); mat[5, 6] = int.Parse(TextBox127.Text); mat[5, 7] = int.Parse(TextBox128.Text); mat[5, 8] = int.Parse(TextBox129.Text); mat[5, 9] = int.Parse(TextBox130.Text);
            mat[5, 10] = int.Parse(TextBox131.Text); mat[5, 11] = int.Parse(TextBox132.Text); mat[5, 12] = int.Parse(TextBox133.Text); mat[5, 13] = int.Parse(TextBox134.Text); mat[5, 14] = int.Parse(TextBox135.Text); mat[5, 15] = int.Parse(TextBox136.Text); mat[5, 16] = int.Parse(TextBox137.Text); mat[5, 17] = int.Parse(TextBox138.Text); mat[5, 18] = int.Parse(TextBox139.Text); mat[5, 19] = int.Parse(TextBox140.Text);

            mat[6, 0] = int.Parse(TextBox141.Text); mat[6, 1] = int.Parse(TextBox142.Text); mat[6, 2] = int.Parse(TextBox143.Text); mat[6, 3] = int.Parse(TextBox144.Text); mat[6, 4] = int.Parse(TextBox145.Text); mat[6, 5] = int.Parse(TextBox146.Text); mat[6, 6] = int.Parse(TextBox147.Text); mat[6, 7] = int.Parse(TextBox148.Text); mat[6, 8] = int.Parse(TextBox149.Text); mat[6, 9] = int.Parse(TextBox150.Text);
            mat[6, 10] = int.Parse(TextBox151.Text); mat[6, 11] = int.Parse(TextBox152.Text); mat[6, 12] = int.Parse(TextBox153.Text); mat[6, 13] = int.Parse(TextBox154.Text); mat[6, 14] = int.Parse(TextBox155.Text); mat[6, 15] = int.Parse(TextBox156.Text); mat[6, 16] = int.Parse(TextBox157.Text); mat[6, 17] = int.Parse(TextBox158.Text); mat[6, 18] = int.Parse(TextBox159.Text); mat[6, 19] = int.Parse(TextBox160.Text);

            mat[7, 0] = int.Parse(TextBox161.Text); mat[7, 1] = int.Parse(TextBox162.Text); mat[7, 2] = int.Parse(TextBox163.Text); mat[7, 3] = int.Parse(TextBox164.Text); mat[7, 4] = int.Parse(TextBox165.Text); mat[7, 5] = int.Parse(TextBox166.Text); mat[7, 6] = int.Parse(TextBox167.Text); mat[7, 7] = int.Parse(TextBox168.Text); mat[7, 8] = int.Parse(TextBox169.Text); mat[7, 9] = int.Parse(TextBox170.Text);
            mat[7, 10] = int.Parse(TextBox171.Text); mat[7, 11] = int.Parse(TextBox172.Text); mat[7, 12] = int.Parse(TextBox173.Text); mat[7, 13] = int.Parse(TextBox174.Text); mat[7, 14] = int.Parse(TextBox175.Text); mat[7, 15] = int.Parse(TextBox176.Text); mat[7, 16] = int.Parse(TextBox177.Text); mat[7, 17] = int.Parse(TextBox178.Text); mat[7, 18] = int.Parse(TextBox179.Text); mat[7, 19] = int.Parse(TextBox180.Text);

            mat[8, 0] = int.Parse(TextBox181.Text); mat[8, 1] = int.Parse(TextBox182.Text); mat[8, 2] = int.Parse(TextBox183.Text); mat[8, 3] = int.Parse(TextBox184.Text); mat[8, 4] = int.Parse(TextBox185.Text); mat[8, 5] = int.Parse(TextBox186.Text); mat[8, 6] = int.Parse(TextBox187.Text); mat[8, 7] = int.Parse(TextBox188.Text); mat[8, 8] = int.Parse(TextBox189.Text); mat[8, 9] = int.Parse(TextBox190.Text);
            mat[8, 10] = int.Parse(TextBox191.Text); mat[8, 11] = int.Parse(TextBox192.Text); mat[8, 12] = int.Parse(TextBox193.Text); mat[8, 13] = int.Parse(TextBox194.Text); mat[8, 14] = int.Parse(TextBox195.Text); mat[8, 15] = int.Parse(TextBox196.Text); mat[8, 16] = int.Parse(TextBox197.Text); mat[8, 17] = int.Parse(TextBox198.Text); mat[8, 18] = int.Parse(TextBox199.Text); mat[8, 19] = int.Parse(TextBox200.Text);

            mat[9, 0] = int.Parse(TextBox201.Text); mat[9, 1] = int.Parse(TextBox202.Text); mat[9, 2] = int.Parse(TextBox203.Text); mat[9, 3] = int.Parse(TextBox204.Text); mat[9, 4] = int.Parse(TextBox205.Text); mat[9, 5] = int.Parse(TextBox206.Text); mat[9, 6] = int.Parse(TextBox207.Text); mat[9, 7] = int.Parse(TextBox208.Text); mat[9, 8] = int.Parse(TextBox209.Text); mat[9, 9] = int.Parse(TextBox210.Text);
            mat[9, 10] = int.Parse(TextBox211.Text); mat[9, 11] = int.Parse(TextBox212.Text); mat[9, 12] = int.Parse(TextBox213.Text); mat[9, 13] = int.Parse(TextBox214.Text); mat[9, 14] = int.Parse(TextBox215.Text); mat[9, 15] = int.Parse(TextBox216.Text); mat[9, 16] = int.Parse(TextBox217.Text); mat[9, 17] = int.Parse(TextBox218.Text); mat[9, 18] = int.Parse(TextBox219.Text); mat[9, 19] = int.Parse(TextBox220.Text);

            mat[10, 0] = int.Parse(TextBox221.Text); mat[10, 1] = int.Parse(TextBox222.Text); mat[10, 2] = int.Parse(TextBox223.Text); mat[10, 3] = int.Parse(TextBox224.Text); mat[10, 4] = int.Parse(TextBox225.Text); mat[10, 5] = int.Parse(TextBox226.Text); mat[10, 6] = int.Parse(TextBox227.Text); mat[10, 7] = int.Parse(TextBox228.Text); mat[10, 8] = int.Parse(TextBox229.Text); mat[10, 9] = int.Parse(TextBox230.Text);
            mat[10, 10] = int.Parse(TextBox231.Text); mat[10, 11] = int.Parse(TextBox232.Text); mat[10, 12] = int.Parse(TextBox233.Text); mat[10, 13] = int.Parse(TextBox234.Text); mat[10, 14] = int.Parse(TextBox235.Text); mat[10, 15] = int.Parse(TextBox236.Text); mat[10, 16] = int.Parse(TextBox237.Text); mat[10, 17] = int.Parse(TextBox238.Text); mat[10, 18] = int.Parse(TextBox239.Text); mat[10, 19] = int.Parse(TextBox240.Text);

            mat[11, 0] = int.Parse(TextBox241.Text); mat[11, 1] = int.Parse(TextBox242.Text); mat[11, 2] = int.Parse(TextBox243.Text); mat[11, 3] = int.Parse(TextBox244.Text); mat[11, 4] = int.Parse(TextBox245.Text); mat[11, 5] = int.Parse(TextBox246.Text); mat[11, 6] = int.Parse(TextBox247.Text); mat[11, 7] = int.Parse(TextBox248.Text); mat[11, 8] = int.Parse(TextBox249.Text); mat[11, 9] = int.Parse(TextBox250.Text);
            mat[11, 10] = int.Parse(TextBox251.Text); mat[11, 11] = int.Parse(TextBox252.Text); mat[11, 12] = int.Parse(TextBox253.Text); mat[11, 13] = int.Parse(TextBox254.Text); mat[11, 14] = int.Parse(TextBox255.Text); mat[11, 15] = int.Parse(TextBox256.Text); mat[11, 16] = int.Parse(TextBox257.Text); mat[11, 17] = int.Parse(TextBox258.Text); mat[11, 18] = int.Parse(TextBox259.Text); mat[11, 19] = int.Parse(TextBox260.Text);

            mat[12, 0] = int.Parse(TextBox261.Text); mat[12, 1] = int.Parse(TextBox262.Text); mat[12, 2] = int.Parse(TextBox263.Text); mat[12, 3] = int.Parse(TextBox264.Text); mat[12, 4] = int.Parse(TextBox265.Text); mat[12, 5] = int.Parse(TextBox266.Text); mat[12, 6] = int.Parse(TextBox267.Text); mat[12, 7] = int.Parse(TextBox268.Text); mat[12, 8] = int.Parse(TextBox269.Text); mat[12, 9] = int.Parse(TextBox270.Text);
            mat[12, 10] = int.Parse(TextBox271.Text); mat[12, 11] = int.Parse(TextBox272.Text); mat[12, 12] = int.Parse(TextBox273.Text); mat[12, 13] = int.Parse(TextBox274.Text); mat[12, 14] = int.Parse(TextBox275.Text); mat[12, 15] = int.Parse(TextBox276.Text); mat[12, 16] = int.Parse(TextBox277.Text); mat[12, 17] = int.Parse(TextBox278.Text); mat[12, 18] = int.Parse(TextBox279.Text); mat[12, 19] = int.Parse(TextBox280.Text);

            mat[13, 0] = int.Parse(TextBox281.Text); mat[13, 1] = int.Parse(TextBox282.Text); mat[13, 2] = int.Parse(TextBox283.Text); mat[13, 3] = int.Parse(TextBox284.Text); mat[13, 4] = int.Parse(TextBox285.Text); mat[13, 5] = int.Parse(TextBox286.Text); mat[13, 6] = int.Parse(TextBox287.Text); mat[13, 7] = int.Parse(TextBox288.Text); mat[13, 8] = int.Parse(TextBox289.Text); mat[13, 9] = int.Parse(TextBox290.Text);
            mat[13, 10] = int.Parse(TextBox291.Text); mat[13, 11] = int.Parse(TextBox292.Text); mat[13, 12] = int.Parse(TextBox293.Text); mat[13, 13] = int.Parse(TextBox294.Text); mat[13, 14] = int.Parse(TextBox295.Text); mat[13, 15] = int.Parse(TextBox296.Text); mat[13, 16] = int.Parse(TextBox297.Text); mat[13, 17] = int.Parse(TextBox298.Text); mat[13, 18] = int.Parse(TextBox299.Text); mat[13, 19] = int.Parse(TextBox300.Text);

            mat[14, 0] = int.Parse(TextBox301.Text); mat[14, 1] = int.Parse(TextBox302.Text); mat[14, 2] = int.Parse(TextBox303.Text); mat[14, 3] = int.Parse(TextBox304.Text); mat[14, 4] = int.Parse(TextBox305.Text); mat[14, 5] = int.Parse(TextBox306.Text); mat[14, 6] = int.Parse(TextBox307.Text); mat[14, 7] = int.Parse(TextBox308.Text); mat[14, 8] = int.Parse(TextBox309.Text); mat[14, 9] = int.Parse(TextBox310.Text);
            mat[14, 10] = int.Parse(TextBox311.Text); mat[14, 11] = int.Parse(TextBox312.Text); mat[14, 12] = int.Parse(TextBox313.Text); mat[14, 13] = int.Parse(TextBox314.Text); mat[14, 14] = int.Parse(TextBox315.Text); mat[14, 15] = int.Parse(TextBox316.Text); mat[14, 16] = int.Parse(TextBox317.Text); mat[14, 17] = int.Parse(TextBox318.Text); mat[14, 18] = int.Parse(TextBox319.Text); mat[14, 19] = int.Parse(TextBox320.Text);

            mat[15, 0] = int.Parse(TextBox321.Text); mat[15, 1] = int.Parse(TextBox322.Text); mat[15, 2] = int.Parse(TextBox323.Text); mat[15, 3] = int.Parse(TextBox324.Text); mat[15, 4] = int.Parse(TextBox325.Text); mat[15, 5] = int.Parse(TextBox326.Text); mat[15, 6] = int.Parse(TextBox327.Text); mat[15, 7] = int.Parse(TextBox328.Text); mat[15, 8] = int.Parse(TextBox329.Text); mat[15, 9] = int.Parse(TextBox330.Text);
            mat[15, 10] = int.Parse(TextBox331.Text); mat[15, 11] = int.Parse(TextBox332.Text); mat[15, 12] = int.Parse(TextBox333.Text); mat[15, 13] = int.Parse(TextBox334.Text); mat[15, 14] = int.Parse(TextBox335.Text); mat[15, 15] = int.Parse(TextBox336.Text); mat[15, 16] = int.Parse(TextBox337.Text); mat[15, 17] = int.Parse(TextBox338.Text); mat[15, 18] = int.Parse(TextBox339.Text); mat[15, 19] = int.Parse(TextBox340.Text);

            mat[16, 0] = int.Parse(TextBox341.Text); mat[16, 1] = int.Parse(TextBox342.Text); mat[16, 2] = int.Parse(TextBox343.Text); mat[16, 3] = int.Parse(TextBox344.Text); mat[16, 4] = int.Parse(TextBox345.Text); mat[15, 5] = int.Parse(TextBox346.Text); mat[16, 6] = int.Parse(TextBox347.Text); mat[16, 7] = int.Parse(TextBox348.Text); mat[16, 8] = int.Parse(TextBox349.Text); mat[16, 9] = int.Parse(TextBox350.Text);
            mat[16, 10] = int.Parse(TextBox351.Text); mat[16, 11] = int.Parse(TextBox352.Text); mat[16, 12] = int.Parse(TextBox353.Text); mat[16, 13] = int.Parse(TextBox354.Text); mat[16, 14] = int.Parse(TextBox355.Text); mat[15, 15] = int.Parse(TextBox356.Text); mat[16, 16] = int.Parse(TextBox357.Text); mat[16, 17] = int.Parse(TextBox358.Text); mat[16, 18] = int.Parse(TextBox359.Text); mat[16, 19] = int.Parse(TextBox360.Text);

            mat[17, 0] = int.Parse(TextBox361.Text); mat[17, 1] = int.Parse(TextBox362.Text); mat[17, 2] = int.Parse(TextBox363.Text); mat[17, 3] = int.Parse(TextBox364.Text); mat[17, 4] = int.Parse(TextBox365.Text); mat[17, 5] = int.Parse(TextBox366.Text); mat[17, 6] = int.Parse(TextBox367.Text); mat[17, 7] = int.Parse(TextBox368.Text); mat[17, 8] = int.Parse(TextBox369.Text); mat[17, 9] = int.Parse(TextBox370.Text);
            mat[17, 10] = int.Parse(TextBox371.Text); mat[17, 11] = int.Parse(TextBox372.Text); mat[17, 12] = int.Parse(TextBox373.Text); mat[17, 13] = int.Parse(TextBox374.Text); mat[17, 14] = int.Parse(TextBox375.Text); mat[17, 15] = int.Parse(TextBox376.Text); mat[17, 16] = int.Parse(TextBox377.Text); mat[17, 17] = int.Parse(TextBox378.Text); mat[17, 18] = int.Parse(TextBox379.Text); mat[17, 19] = int.Parse(TextBox380.Text);

            mat[18, 0] = int.Parse(TextBox381.Text); mat[18, 1] = int.Parse(TextBox382.Text); mat[18, 2] = int.Parse(TextBox383.Text); mat[18, 3] = int.Parse(TextBox384.Text); mat[18, 4] = int.Parse(TextBox385.Text); mat[18, 5] = int.Parse(TextBox386.Text); mat[18, 6] = int.Parse(TextBox387.Text); mat[18, 7] = int.Parse(TextBox388.Text); mat[18, 8] = int.Parse(TextBox389.Text); mat[18, 9] = int.Parse(TextBox390.Text);
            mat[18, 10] = int.Parse(TextBox391.Text); mat[18, 11] = int.Parse(TextBox392.Text); mat[18, 12] = int.Parse(TextBox393.Text); mat[18, 13] = int.Parse(TextBox394.Text); mat[18, 14] = int.Parse(TextBox395.Text); mat[18, 15] = int.Parse(TextBox396.Text); mat[18, 16] = int.Parse(TextBox397.Text); mat[18, 17] = int.Parse(TextBox398.Text); mat[18, 18] = int.Parse(TextBox399.Text); mat[18, 19] = int.Parse(TextBox400.Text);

            mat[19, 0] = int.Parse(TextBox401.Text); mat[19, 1] = int.Parse(TextBox402.Text); mat[19, 2] = int.Parse(TextBox403.Text); mat[19, 3] = int.Parse(TextBox404.Text); mat[19, 4] = int.Parse(TextBox405.Text); mat[19, 5] = int.Parse(TextBox406.Text); mat[19, 6] = int.Parse(TextBox407.Text); mat[19, 7] = int.Parse(TextBox408.Text); mat[19, 8] = int.Parse(TextBox409.Text); mat[19, 9] = int.Parse(TextBox410.Text);
            mat[19, 10] = int.Parse(TextBox411.Text); mat[19, 11] = int.Parse(TextBox412.Text); mat[19, 12] = int.Parse(TextBox413.Text); mat[19, 13] = int.Parse(TextBox414.Text); mat[19, 14] = int.Parse(TextBox415.Text); mat[19, 15] = int.Parse(TextBox416.Text); mat[19, 16] = int.Parse(TextBox417.Text); mat[19, 17] = int.Parse(TextBox418.Text); mat[19, 18] = int.Parse(TextBox419.Text); mat[19, 19] = int.Parse(TextBox420.Text);


            for (i = 0; i < max; i++)
            {
                for (j = 0; j < max; j++)
                {
                    sumrow[i] += mat[i, j];
                    sumcol[i] += mat[j, i];
                }
            }


            for (i = 0; i < max; i++)
            {
                bus[i] = sumrow[i] - sumcol[i] + x;
                x = bus[i];
                //TextBox442.Text += bus[m].ToString() + "\n";
            }

            //TextBox442.Text += "\n****************************\n";



            for (i = 0; i < max; i++)
            {
                for (j = 0; j < max; j++)
                {
                    temp[i, j] = mat[i, j];
                }
            }

            for (m = 0; m < max; m++)
            {
                x = 0;
                for (k = 0; k <= m; k++)
                {
                    for (l = (m + 1); l < max; l++)
                    {
                        x += mat[k, l];
                    }
                }
                bus[m] = x;
                //TextBox442.Text += bus[m].ToString() + "\n";
            }


            //matrix();




            void matrix()
            {


                for (m = 0; m < max; m++)
                {
                    x = 0;
                    for (k = 0; k <= m; k++)
                    {
                        for (l = (m + 1); l < max; l++)
                        {
                            x += temp[k, l];
                        }
                    }
                    bus[m] = x;
                    //TextBox443.Text += bus[m].ToString() + "\n";
                }
                //TextBox443.Text += "\n------------------------\n";
            }

            skip = "";
            for (i = 0; i < max; i++)
            {
                if (bus[i] > value)
                {
                    skip += "Station" + (i + 1).ToString() + "\n";
                    skipped[i] = 1;
                    for (k = 0; k < max; k++)
                    {
                        //for(l=0; l<8; l++)
                        {
                            temp[k, i] = 0;
                            temp[i, k] = 0;
                        }
                    }
                }
                matrix();

                TextBox421.Text = bus[0].ToString(); TextBox422.Text = bus[1].ToString(); TextBox423.Text = bus[2].ToString(); TextBox424.Text = bus[3].ToString(); TextBox425.Text = bus[4].ToString(); TextBox426.Text = bus[5].ToString();
                TextBox427.Text = bus[6].ToString(); TextBox428.Text = bus[7].ToString(); TextBox429.Text = bus[8].ToString(); TextBox430.Text = bus[9].ToString(); TextBox431.Text = bus[10].ToString(); TextBox432.Text = bus[11].ToString();
                TextBox433.Text = bus[12].ToString(); TextBox434.Text = bus[13].ToString(); TextBox435.Text = bus[14].ToString(); TextBox436.Text = bus[15].ToString(); TextBox437.Text = bus[16].ToString(); TextBox438.Text = bus[17].ToString();
                TextBox439.Text = bus[18].ToString(); TextBox440.Text = bus[19].ToString();
            }
            TextBox442.Text = "****First Line*****\n";

            for (i = 0; i < max; i++)
            {
                skippedsec[i] = 0;
                if (skipped[i] == 1)
                {
                    TextBox442.Text += "Skipping Station" + (i + 1).ToString() + "\n";
                }
                else
                {
                    TextBox442.Text += "Station" + (i + 1).ToString() + "\n";
                }
            }

            for (i = 1; i < (max - 1); i++)
            {
                if (skipped[i] == 1)
                {
                    if (skipped[i - 1] == 0)
                    {
                        skippedsec[i - 1] = 1;
                    }
                    else if ((skipped[i - 1] == 1) & (i > 1))
                    {
                        skippedsec[i - 2] = 1;
                    }

                    if (skipped[i + 1] == 0)
                    {
                        skippedsec[i + 1] = 1;
                    }
                    else if ((skipped[i + 1] == 1) & (i < (max - 2)))
                    {
                        skippedsec[i + 2] = 1;
                    }
                }
            }
            TextBox443.Text = "*****Second Line****\n";
            for (i = 0; i < max; i++)
            {
                if (skippedsec[i] == 1 & skipped[i] != 1)
                {
                    TextBox443.Text += "Skipping Station" + (i + 1).ToString()+ "\n";
                }
                else
                {
                    TextBox443.Text += "Station" + (i + 1).ToString() + "\n";
                }

            }

            
                Image1.Visible = true;
                Image1.Visible = true;
                Bitmap bitmap = new Bitmap(1300, 250, PixelFormat.Format64bppPArgb);

                Graphics graphics = Graphics.FromImage(bitmap);



                bitmap.SetResolution(1300, 250);
                graphics = Graphics.FromImage(bitmap);
                graphics.Clear(Color.White);
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                //graphics.DrawImage(bitmap,500,100,500,100);
                StringFormat sf = new StringFormat();
                sf.LineAlignment = StringAlignment.Near;
                sf.Alignment = StringAlignment.Center;

                sf.LineAlignment = StringAlignment.Center;
                sf.Alignment = StringAlignment.Center;

                Font font2 = new Font("Arial", (int)(12), FontStyle.Bold, GraphicsUnit.Pixel);

                Bitmap[] img = new Bitmap[20];
            img[0] = (Bitmap)System.Drawing.Image.FromFile(HttpContext.Current.Server.MapPath("~/images/Station1.jpg"));
            img[1] = (Bitmap)System.Drawing.Image.FromFile(HttpContext.Current.Server.MapPath("~/images/Station2.jpg"));
            img[2] = (Bitmap)System.Drawing.Image.FromFile(HttpContext.Current.Server.MapPath("~/images/Station3.jpg"));
            img[3] = (Bitmap)System.Drawing.Image.FromFile(HttpContext.Current.Server.MapPath("~/images/Station4.jpg"));
            img[4] = (Bitmap)System.Drawing.Image.FromFile(HttpContext.Current.Server.MapPath("~/images/Station5.jpg"));
            img[5] = (Bitmap)System.Drawing.Image.FromFile(HttpContext.Current.Server.MapPath("~/images/Station6.jpg"));
            img[6] = (Bitmap)System.Drawing.Image.FromFile(HttpContext.Current.Server.MapPath("~/images/Station7.jpg"));
            img[7] = (Bitmap)System.Drawing.Image.FromFile(HttpContext.Current.Server.MapPath("~/images/Station8.jpg"));
            img[8] = (Bitmap)System.Drawing.Image.FromFile(HttpContext.Current.Server.MapPath("~/images/Station9.jpg"));
            img[9] = (Bitmap)System.Drawing.Image.FromFile(HttpContext.Current.Server.MapPath("~/images/Station10.jpg"));
            img[10] = (Bitmap)System.Drawing.Image.FromFile(HttpContext.Current.Server.MapPath("~/images/Station11.jpg"));
            img[11] = (Bitmap)System.Drawing.Image.FromFile(HttpContext.Current.Server.MapPath("~/images/Station12.jpg"));
            img[12] = (Bitmap)System.Drawing.Image.FromFile(HttpContext.Current.Server.MapPath("~/images/Station13.jpg"));
            img[13] = (Bitmap)System.Drawing.Image.FromFile(HttpContext.Current.Server.MapPath("~/images/Station14.jpg"));
            img[14] = (Bitmap)System.Drawing.Image.FromFile(HttpContext.Current.Server.MapPath("~/images/Station15.jpg"));
            img[15] = (Bitmap)System.Drawing.Image.FromFile(HttpContext.Current.Server.MapPath("~/images/Station16.jpg"));
            img[16] = (Bitmap)System.Drawing.Image.FromFile(HttpContext.Current.Server.MapPath("~/images/Station17.jpg"));
            img[17] = (Bitmap)System.Drawing.Image.FromFile(HttpContext.Current.Server.MapPath("~/images/Station18.jpg"));
            img[18] = (Bitmap)System.Drawing.Image.FromFile(HttpContext.Current.Server.MapPath("~/images/Station19.jpg"));
            img[19] = (Bitmap)System.Drawing.Image.FromFile(HttpContext.Current.Server.MapPath("~/images/Station20.jpg"));

            int down = 5, right = 10, t = 65, t1 = 3;
                y = 60; x = 60;

            //TextBox442.Text += Directory.GetCurrentDirectory();


                for (k = 0; k < max; k++)
                {
                    RectangleF src = new RectangleF(right, down, x, y);
                    graphics.DrawImage(img[k], src);
                    if (skipped[k] == 1)
                    {
                        graphics.DrawLine(new Pen(Color.Blue, 2), new Point(right - t1, t1), new Point(right + t1 + x, t1));
                        graphics.DrawLine(new Pen(Color.Blue, 2), new Point(right - t1, t1), new Point(right - t1, t));
                        graphics.DrawLine(new Pen(Color.Blue, 2), new Point(right + t1 + x, t1), new Point(right + t1 + x, t));
                        graphics.DrawString("Skipped", font2, new SolidBrush(Color.FromArgb(0, 0, 0)), right + 30, t+10, sf);
                    }
                    right += 65;
                }
                graphics.DrawLine(new Pen(Color.Gray, 2), new Point(0, t), new Point(1300, t));

                right = 10;
                down = 120;
                for (k = 0; k < max; k++)
                {
                    RectangleF src = new RectangleF(right, down, x, y);
                    graphics.DrawImage(img[k], src);
                    if (skippedsec[k] == 1)
                    {
                        graphics.DrawLine(new Pen(Color.Blue, 2), new Point(right - t1, 118), new Point(right + t1 + x, 118));
                        graphics.DrawLine(new Pen(Color.Blue, 2), new Point(right - t1, 118), new Point(right - t1, t + 115));
                        graphics.DrawLine(new Pen(Color.Blue, 2), new Point(right + t1 + x, 118), new Point(right + t1 + x, t + 115));
                        graphics.DrawString("Skipped", font2, new SolidBrush(Color.FromArgb(0, 0, 0)), right + 30, 190, sf);
                    }
                    right += 65;
                }
                graphics.DrawLine(new Pen(Color.Gray, 2), new Point(0, t + 115), new Point(1300, t + 115));



                graphics.DrawString("Run1", font2, new SolidBrush(Color.FromArgb(200, 0, 0)), 20, 85, sf);
                graphics.DrawString("Run2", font2, new SolidBrush(Color.FromArgb(200, 0, 0)), 20, 200, sf);



                graphics.Flush();
                graphics.Dispose();
                //string fileName = Path.GetFileNameWithoutExtension(Path.GetRandomFileName()) + ".jpg";
                string fileName = "figure1" + ".jpg";
                bitmap.Save(Server.MapPath("~/images/jpg/") + fileName, ImageFormat.Jpeg);
                Image1.ImageUrl = "~/images/jpg/" + fileName;

               // MemoryStream ms = new MemoryStream();            
               // bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                //Byte[] arr = new byte[ms.Length];
               // arr = new byte[ms.Length];
                //arr = ms.ToArray();
               // string base64String = Convert.ToBase64String(arr, 0, arr.Length);

               // Image1.ImageUrl = "data:image/jpg;base64," + base64String;


                graphics.Dispose();
                bitmap.Dispose();
            
    }
        

        protected void Button3_Click(object sender, EventArgs e)
        {
            TextBox442.Text = "";
            TextBox443.Text = "";

            int max = int.Parse(DropDownList41.SelectedValue.ToString());
            int value = int.Parse(TextBox444.Text);
            int i, j, x, x1,k, y = 0;
            int[,] mat2 = new int[20, 2];
            int[] sum = new int[20];
            int[] skip = new int[20];
            int[] skip2 = new int[20];

            for (i = 0; i < 20; i++)
            {
                sum[i] = 0;
                skip[i] = 0;
                skip2[i] = 0;
                for (j = 0; j < 2; j++)
                {
                    mat2[i, j] = 0;
                }
            }

            mat2[0, 0] = int.Parse(DropDownList1.SelectedValue.ToString());
            mat2[1, 0] = int.Parse(DropDownList2.SelectedValue.ToString());
            mat2[2, 0] = int.Parse(DropDownList3.SelectedValue.ToString());
            mat2[3, 0] = int.Parse(DropDownList4.SelectedValue.ToString());
            mat2[4, 0] = int.Parse(DropDownList5.SelectedValue.ToString());
            mat2[5, 0] = int.Parse(DropDownList6.SelectedValue.ToString());
            mat2[6, 0] = int.Parse(DropDownList7.SelectedValue.ToString());
            mat2[7, 0] = int.Parse(DropDownList8.SelectedValue.ToString());
            mat2[8, 0] = int.Parse(DropDownList9.SelectedValue.ToString());
            mat2[9, 0] = int.Parse(DropDownList10.SelectedValue.ToString());
            mat2[10, 0] = int.Parse(DropDownList11.SelectedValue.ToString());
            mat2[11, 0] = int.Parse(DropDownList12.SelectedValue.ToString());
            mat2[12, 0] = int.Parse(DropDownList13.SelectedValue.ToString());
            mat2[13, 0] = int.Parse(DropDownList14.SelectedValue.ToString());
            mat2[14, 0] = int.Parse(DropDownList15.SelectedValue.ToString());
            mat2[15, 0] = int.Parse(DropDownList16.SelectedValue.ToString());
            mat2[16, 0] = int.Parse(DropDownList17.SelectedValue.ToString());
            mat2[17, 0] = int.Parse(DropDownList18.SelectedValue.ToString());
            mat2[18, 0] = int.Parse(DropDownList19.SelectedValue.ToString());
            mat2[19, 0] = int.Parse(DropDownList20.SelectedValue.ToString());

            mat2[0, 1] = int.Parse(DropDownList21.SelectedValue.ToString());
            mat2[1, 1] = int.Parse(DropDownList22.SelectedValue.ToString());
            mat2[2, 1] = int.Parse(DropDownList23.SelectedValue.ToString());
            mat2[3, 1] = int.Parse(DropDownList24.SelectedValue.ToString());
            mat2[4, 1] = int.Parse(DropDownList25.SelectedValue.ToString());
            mat2[5, 1] = int.Parse(DropDownList26.SelectedValue.ToString());
            mat2[6, 1] = int.Parse(DropDownList27.SelectedValue.ToString());
            mat2[7, 1] = int.Parse(DropDownList28.SelectedValue.ToString());
            mat2[8, 1] = int.Parse(DropDownList29.SelectedValue.ToString());
            mat2[9, 1] = int.Parse(DropDownList30.SelectedValue.ToString());
            mat2[10, 1] = int.Parse(DropDownList31.SelectedValue.ToString());
            mat2[11, 1] = int.Parse(DropDownList32.SelectedValue.ToString());
            mat2[12, 1] = int.Parse(DropDownList33.SelectedValue.ToString());
            mat2[13, 1] = int.Parse(DropDownList34.SelectedValue.ToString());
            mat2[14, 1] = int.Parse(DropDownList35.SelectedValue.ToString());
            mat2[15, 1] = int.Parse(DropDownList36.SelectedValue.ToString());
            mat2[16, 1] = int.Parse(DropDownList37.SelectedValue.ToString());
            mat2[17, 1] = int.Parse(DropDownList38.SelectedValue.ToString());
            mat2[18, 1] = int.Parse(DropDownList39.SelectedValue.ToString());
            mat2[19, 1] = int.Parse(DropDownList40.SelectedValue.ToString());


            train();

           void train()
            {
                y = 0;
                for (i = 0; i < max; i++)
                {
                    x = mat2[i, 0] - mat2[i, 1];
                    y += x;
                    sum[i] = y;
                }
                TextBox1.Text = sum[0].ToString();
                TextBox2.Text = sum[1].ToString();
                TextBox3.Text = sum[2].ToString();
                TextBox4.Text = sum[3].ToString();
                TextBox5.Text = sum[4].ToString();
                TextBox6.Text = sum[5].ToString();
                TextBox7.Text = sum[6].ToString();
                TextBox8.Text = sum[7].ToString();
                TextBox9.Text = sum[8].ToString();
                TextBox10.Text = sum[9].ToString();
                TextBox11.Text = sum[10].ToString();
                TextBox12.Text = sum[11].ToString();
                TextBox13.Text = sum[12].ToString();
                TextBox14.Text = sum[13].ToString();
                TextBox15.Text = sum[14].ToString();
                TextBox16.Text = sum[15].ToString();
                TextBox17.Text = sum[16].ToString();
                TextBox18.Text = sum[17].ToString();
                TextBox19.Text = sum[18].ToString();
                TextBox20.Text = sum[19].ToString();
            }

            x1 = value;
            int j2 = 0;
            for (j = 0; j <(max); j++)
            {
                if (sum[j] > x1)
                {
                   // skip[j2] = j;
                    skip2[j] = 1;
                    j2++;
                    mat2[j, 0] = 0;

                    if (j > 0)
                    {
                        mat2[j - 1, 1] += mat2[j, 1];
                        mat2[j, 1] = 0;
                    }
                    train();
                    j = 0;
                }
            }


            TextBox442.Text = "****First Line*****\n";
            TextBox443.Text = "****Second Line*****\n";
            for (i = 0; i < max; i++)
            {
                if (skip2[i] == 0)
                    TextBox442.Text += "Station " + (i+1).ToString()+"\n";
                else
                    TextBox442.Text += "Skip of Station " + (i+1).ToString()+"\n";
            }

            

            for (i = 0; i < (max-2); i++)
            {
                if(skip2[i+1]==1)
                {
                    skip[i] = skip[i + 2] = 1;
                }
            }

            if (skip2[0] == 1 & skip2[1] == 0)
            {
                skip[1] = 1;
            }

            if (skip2[max - 1] == 1 & skip2[max - 2] == 0)
            {
                skip[max - 2] = 1;
            }

            for (i = 0; i < max; i++)
            {
                if (skip[i] == 0 | skip2[i] == 1)
                {
                    TextBox443.Text += "Station  " + (i+1).ToString() + "\n";
                    skip[i] = 0;
                }
                else
                {
                    TextBox443.Text += "Skip of Station " + (i+1).ToString() + "\n";
                    skip[i] = 1;
                }
            }

            //----------------------------------------------------------------------------------------
            
            Image1.Visible = true;
            Image1.Visible = true;
            Bitmap bitmap = new Bitmap(1300, 250, PixelFormat.Format64bppPArgb);

            Graphics graphics = Graphics.FromImage(bitmap);



            bitmap.SetResolution(1300, 250);
            graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            graphics.CompositingQuality = CompositingQuality.HighQuality;
            //graphics.DrawImage(bitmap,500,100,500,100);
            StringFormat sf = new StringFormat();
            sf.LineAlignment = StringAlignment.Near;
            sf.Alignment = StringAlignment.Center;

            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Center;

            Font font2 = new Font("Arial", (int)(12), FontStyle.Bold, GraphicsUnit.Pixel);

            string[] imagename = new string[20];
            
            Bitmap[] img = new Bitmap[20];
            img[0] = (Bitmap)System.Drawing.Image.FromFile(HttpContext.Current.Server.MapPath("~/images/Station1.jpg"));
            img[1] = (Bitmap)System.Drawing.Image.FromFile(HttpContext.Current.Server.MapPath("~/images/Station2.jpg"));
            img[2] = (Bitmap)System.Drawing.Image.FromFile(HttpContext.Current.Server.MapPath("~/images/Station3.jpg"));
            img[3] = (Bitmap)System.Drawing.Image.FromFile(HttpContext.Current.Server.MapPath("~/images/Station4.jpg"));
            img[4] = (Bitmap)System.Drawing.Image.FromFile(HttpContext.Current.Server.MapPath("~/images/Station5.jpg"));
            img[5] = (Bitmap)System.Drawing.Image.FromFile(HttpContext.Current.Server.MapPath("~/images/Station6.jpg"));
            img[6] = (Bitmap)System.Drawing.Image.FromFile(HttpContext.Current.Server.MapPath("~/images/Station7.jpg"));
            img[7] = (Bitmap)System.Drawing.Image.FromFile(HttpContext.Current.Server.MapPath("~/images/Station8.jpg"));
            img[8] = (Bitmap)System.Drawing.Image.FromFile(HttpContext.Current.Server.MapPath("~/images/Station9.jpg"));
            img[9] = (Bitmap)System.Drawing.Image.FromFile(HttpContext.Current.Server.MapPath("~/images/Station10.jpg"));
            img[10] = (Bitmap)System.Drawing.Image.FromFile(HttpContext.Current.Server.MapPath("~/images/Station11.jpg"));
            img[11] = (Bitmap)System.Drawing.Image.FromFile(HttpContext.Current.Server.MapPath("~/images/Station12.jpg"));
            img[12] = (Bitmap)System.Drawing.Image.FromFile(HttpContext.Current.Server.MapPath("~/images/Station13.jpg"));
            img[13] = (Bitmap)System.Drawing.Image.FromFile(HttpContext.Current.Server.MapPath("~/images/Station14.jpg"));
            img[14] = (Bitmap)System.Drawing.Image.FromFile(HttpContext.Current.Server.MapPath("~/images/Station15.jpg"));
            img[15] = (Bitmap)System.Drawing.Image.FromFile(HttpContext.Current.Server.MapPath("~/images/Station16.jpg"));
            img[16] = (Bitmap)System.Drawing.Image.FromFile(HttpContext.Current.Server.MapPath("~/images/Station17.jpg"));
            img[17] = (Bitmap)System.Drawing.Image.FromFile(HttpContext.Current.Server.MapPath("~/images/Station18.jpg"));
            img[18] = (Bitmap)System.Drawing.Image.FromFile(HttpContext.Current.Server.MapPath("~/images/Station19.jpg"));
            img[19] = (Bitmap)System.Drawing.Image.FromFile(HttpContext.Current.Server.MapPath("~/images/Station20.jpg"));

            int down = 5, right = 10, t = 65, t1 = 3;
            y = 60; x = 60;



            for (k = 0; k < max; k++)
            {
                RectangleF src = new RectangleF(right, down, x, y);
                graphics.DrawImage(img[k], src);
                if (skip2[k] == 1)
                {
                    graphics.DrawLine(new Pen(Color.Blue, 2), new Point(right - t1, t1), new Point(right + t1 + x, t1));
                    graphics.DrawLine(new Pen(Color.Blue, 2), new Point(right - t1, t1), new Point(right - t1, t));
                    graphics.DrawLine(new Pen(Color.Blue, 2), new Point(right + t1 + x, t1), new Point(right + t1 + x, t));
                    graphics.DrawString("Skipped", font2, new SolidBrush(Color.FromArgb(0, 0, 0)), right + 30, t + 10, sf);
                }
                right += 65;
            }
            graphics.DrawLine(new Pen(Color.Gray, 2), new Point(0, t), new Point(1300, t));

            right = 10;
            down = 120;
            for (k = 0; k < max; k++)
            {
                RectangleF src = new RectangleF(right, down, x, y);
                graphics.DrawImage(img[k], src);
                if (skip[k] == 1)
                {
                    graphics.DrawLine(new Pen(Color.Blue, 2), new Point(right - t1, 118), new Point(right + t1 + x, 118));
                    graphics.DrawLine(new Pen(Color.Blue, 2), new Point(right - t1, 118), new Point(right - t1, t + 115));
                    graphics.DrawLine(new Pen(Color.Blue, 2), new Point(right + t1 + x, 118), new Point(right + t1 + x, t + 115));
                    graphics.DrawString("Skipped", font2, new SolidBrush(Color.FromArgb(0, 0, 0)), right + 30, 190, sf);
                }
                right += 65;
            }
            graphics.DrawLine(new Pen(Color.Gray, 2), new Point(0, t + 115), new Point(1300, t + 115));



            graphics.DrawString("Run1", font2, new SolidBrush(Color.FromArgb(200, 0, 0)), 20, 85, sf);
            graphics.DrawString("Run2", font2, new SolidBrush(Color.FromArgb(200, 0, 0)), 20, 200, sf);


            graphics.Flush();
            graphics.Dispose();
            //string fileName = Path.GetFileNameWithoutExtension(Path.GetRandomFileName()) + ".jpg";
            string fileName = "figure1" + ".jpg";
            bitmap.Save(Server.MapPath("~/images/jpg/") + fileName, ImageFormat.Jpeg);
            Image1.ImageUrl = "~/images/jpg/" + fileName;



            graphics.Dispose();
            bitmap.Dispose();
            
            //-----------------------------------------------------------------------------------------------------------------
        }
        
    }
}