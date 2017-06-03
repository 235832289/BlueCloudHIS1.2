/*ʾ������
//����ʾ�����ݼ�
private DataTable GetDataTable()
{
    DataTable table = new DataTable();
    table.Columns.Add( "MC" );
    table.Columns.Add( "V1" );
    table.Columns.Add( "V2" );
    table.Columns.Add( "V3" );
    table.Columns.Add( "V4" );
    

    Random random = new Random();
    for ( int i = 0; i < 4; i++ )
    {
        DataRow dr = table.NewRow();
        dr["MC"] = "��" + i.ToString() + "ͥ";
        dr["V1"] = random.Next( 1, 255 );
        dr["V2"] = random.Next( 1, 255 );
        dr["V3"] = random.Next( 1, 255 );
        dr["V4"] = random.Next( 1, 255 );
        

        table.Rows.Add( dr );
    }
    return table;
}
//��ʾ��״ͼ��������ͼ
private void button2_Click( object sender, EventArgs e )
{
    DataTable table = GetDataTable();

    TableColumn[] columns = new TableColumn[4];
    columns[0].ColumnName = "�ɴ�";
    columns[0].ColumnField = "V1";

    columns[1].ColumnName = "����";
    columns[1].ColumnField = "V2";

    columns[2].ColumnName = "�᰸";
    columns[2].ColumnField = "V3";

    columns[3].ColumnName = "�永";
    columns[3].ColumnField = "V4";

    GraphControl gc;
    DataTableStruct datatablestruct = DataTableStruct.Rows; // or =DataTableStruct.Column

    Colors colors = new Color[] { Color.AliceBlue, Color.Aqua, Color.Beige, Color.BlanchedAlmond, Color.Brown, Color.Chocolate, Color.DarkGray, Color.DodgerBlue };

    if ( radioButton1.Checked )
        gc = new HistogramGraphControl( this.panel2, datatablestruct, columns, colors, table, "MC" );
    else
    {
        gc = new LineGraphControl( this.panel2, datatablestruct, columns, colors, table, "MC" );
        
    }
    gc.DrawGraph();
}
//��ʾ��״ͼ
private void button3_Click( object sender, EventArgs e )
{
    DataTable table = GetDataTable();

    TableColumn[] columns = new TableColumn[4];
    columns[0].ColumnName = "�ɴ�";
    columns[0].ColumnField = "V1";

    columns[1].ColumnName = "����";
    columns[1].ColumnField = "V2";

    columns[2].ColumnName = "�᰸";
    columns[2].ColumnField = "V3";

    columns[3].ColumnName = "�永";
    columns[3].ColumnField = "V4";
    DataTableStruct datatableStruct;
    if ( radioButton3.Checked )
        datatableStruct = DataTableStruct.Rows;
    else
        datatableStruct = DataTableStruct.Columns;

    GraphControl gc = new CakyGraphControl( this.panel2, datatableStruct, columns, null, table, "MC" ,0);
    gc.DrawGraph();
}
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using ZedGraph;
namespace HIS_ZYDocManager
{
    public enum DataTableStruct
    {
        /// <summary>
        /// �����ݱ���ֶ�ΪX��̶Ȳ���,��ʱÿ���̶��ڵ�Ԫ��Ϊ���ݱ��ڵļ�¼
        /// </summary>
        Columns,
        /// <summary>
        /// �����ݱ�ļ�¼��ΪX��̶Ȳ���,��ʱÿ���̶��ڵ�Ԫ��Ϊ���ݱ���ֶ�
        /// </summary>
        Rows
    }
    public struct TableColumn
    {
        public string ColumnName;
        public string ColumnField;
    }
    /// <summary>
    /// ͼ�������
    /// </summary>
    public abstract class GraphControl
    {
        /// <summary>
        /// ָ����ͼ����ʾ����
        /// </summary>
        private System.Windows.Forms.Control container;
        /// <summary>
        /// ָ��X��Ŀ̶Ȳ�������(�Լ�¼��Ϊ�̶Ȳ��ջ����ֶ�Ϊ����)
        /// </summary>
        private DataTableStruct xAxisScaleRefrence;
        /// <summary>
        /// Ҫ��ʾ������
        /// </summary>
        private System.Data.DataTable dataSource;
        /// <summary>
        /// ������������
        /// </summary>
        private string cnNameColumn;
        /// <summary>
        /// ͼ�α���
        /// </summary>
        private string graphTitle = "";
        /// <summary>
        /// X�����
        /// </summary>
        private string xAxisTitle = "";
        /// <summary>
        /// Y�����
        /// </summary>
        private string yAxisTitle = "";
        /// <summary>
        /// ���ݱ�����Ϣ
        /// </summary>
        private TableColumn[] showValueColumns;
        private Color[] colors;
        /// <summary>
        /// ָ����ͼ����ʾ����
        /// </summary>
        public System.Windows.Forms.Control GraphContainer
        {
            get
            {
                return container;
            }
            set
            {
                container = value;
            }
        }
        /// <summary>
        /// ָ��X���������Դ
        /// </summary>
        public DataTableStruct XAxisScaleRefrence
        {
            get
            {
                return xAxisScaleRefrence;
            }
            set
            {
                xAxisScaleRefrence = value;
            }
        }
        /// <summary>
        /// Ҫ��ʾ������
        /// </summary>
        public System.Data.DataTable DataSource
        {
            get
            {
                return dataSource;
            }
            set
            {
                dataSource = value;
            }
        }
        /// <summary>
        /// �������ֶ�����
        /// </summary>
        public string CNNameColumn
        {
            get
            {
                return cnNameColumn;
            }
            set
            {
                cnNameColumn = value;
            }
        }
        /// <summary>
        /// ͼ�α���
        /// </summary>
        public string GraphTitle
        {
            get
            {
                return graphTitle;
            }
            set
            {
                graphTitle = value;
            }
        }
        /// <summary>
        /// X�����
        /// </summary>
        public string XAxisTitle
        {
            get
            {
                return xAxisTitle;
            }
            set
            {
                xAxisTitle = value;
            }
        }
        /// <summary>
        /// Y�����
        /// </summary>
        public string YAxisTitle
        {
            get
            {
                return yAxisTitle;
            }
            set
            {
                yAxisTitle = value;
            }
        }
        /// <summary>
        /// ���ݱ����������Ϣ(������������)
        /// </summary>
        public TableColumn[] ShowValueColumns
        {
            get
            {
                return showValueColumns;
            }
            set
            {
                showValueColumns = value;
            }
        }
        public Color[] Colors
        {
            get
            {
                return colors;
            }
            set
            {
                colors = value;
            }
        }
        public System.Drawing.Color GetColor()
        {
            Random rd = new Random();
            int red = rd.Next(0, 255);
            int green = rd.Next(0, 255);
            int blue = rd.Next(0, 255);

            return System.Drawing.Color.FromArgb(red, green, blue);

        }
        /// <summary>
        /// ��ͼ
        /// </summary>
        public abstract void DrawGraph();
    }
    /// <summary>
    /// ��״ͼ
    /// </summary>
    public class HistogramGraphControl : GraphControl
    {
        /// <summary>
        /// ʵ������״ͼ��
        /// </summary>
        /// <param name="GraphContainer">ͼ����ʾ���������</param>
        /// <param name="XAxisScaleRefrence">X��̶Ȳ�������</param>
        /// <param name="ShowValueColumns">��Ҫ��ʾ��ֵ����,�ʹ����DataSource���ж�Ӧ(����ֵ��)</param>
        /// <param name="HistogramColors">ÿ���̶��ڵ�������ɫ�����鳤��ȡ����ÿ���̶��ڵ�����</param>
        /// <param name="DataSource">����Դ</param>
        /// <param name="CNNameColumn">����Դ�е������е��ֶ���</param>
        public HistogramGraphControl(System.Windows.Forms.Control GraphContainer,
            DataTableStruct XAxisScaleRefrence, TableColumn[] ShowValueColumns, Color[] HistogramColors, System.Data.DataTable DataSource,
            string CNNameColumn)
        {
            base.GraphContainer = GraphContainer;
            base.XAxisScaleRefrence = XAxisScaleRefrence;
            base.ShowValueColumns = ShowValueColumns;
            base.DataSource = DataSource;
            base.CNNameColumn = CNNameColumn;
            base.Colors = HistogramColors;
        }
        /// <summary>
        /// ʵ������״ͼ��
        /// </summary>
        /// <param name="GraphContainer">ͼ����ʾ���������</param>
        /// <param name="XAxisScaleRefrence">X��̶Ȳ�������</param>
        /// <param name="ShowValueColumns">��Ҫ��ʾ��ֵ����,�ʹ����DataSource���ж�Ӧ(����ֵ��)</param>
        /// <param name="HistogramColors">ÿ���̶��ڵ�������ɫ�����鳤��ȡ����ÿ���̶��ڵ�����</param>
        /// <param name="DataSource">����Դ</param>
        /// <param name="CNNameColumn">����Դ�е������е��ֶ���</param>
        /// <param name="GraphTitle">ͼ�εı��⣬��ʾ��ͼ�ε����Ϸ�</param>
        public HistogramGraphControl(System.Windows.Forms.Control GraphContainer,
            DataTableStruct XAxisScaleRefrence, TableColumn[] ShowValueColumns, Color[] HistogramColors, System.Data.DataTable DataSource,
            string CNNameColumn, string GraphTitle)
        {
            base.GraphContainer = GraphContainer;
            base.XAxisScaleRefrence = XAxisScaleRefrence;
            base.ShowValueColumns = ShowValueColumns;
            base.DataSource = DataSource;
            base.CNNameColumn = CNNameColumn;
            base.Colors = HistogramColors;
            base.GraphTitle = GraphTitle;
        }
        /// <summary>
        /// ʵ������״ͼ��
        /// </summary>
        /// <param name="GraphContainer">ͼ����ʾ���������</param>
        /// <param name="XAxisScaleRefrence">X��̶Ȳ�������</param>
        /// <param name="ShowValueColumns">��Ҫ��ʾ��ֵ����,�ʹ����DataSource���ж�Ӧ(����ֵ��)</param>
        /// <param name="HistogramColors">ÿ���̶��ڵ�������ɫ�����鳤��ȡ����ÿ���̶��ڵ�����</param>
        /// <param name="DataSource">����Դ</param>
        /// <param name="CNNameColumn">����Դ�е������е��ֶ���</param>
        /// <param name="GraphTitle">ͼ�εı��⣬��ʾ��ͼ�ε����Ϸ�</param>
        /// <param name="XAxisTitle">X�����</param>
        /// <param name="YAxisTitle">Y�����</param>
        public HistogramGraphControl(System.Windows.Forms.Control GraphContainer,
            DataTableStruct XAxisScaleRefrence, TableColumn[] ShowValueColumns, Color[] HistogramColors, System.Data.DataTable DataSource,
            string CNNameColumn, string GraphTitle, string XAxisTitle, string YAxisTitle)
        {
            base.GraphContainer = GraphContainer;
            base.XAxisScaleRefrence = XAxisScaleRefrence;
            base.ShowValueColumns = ShowValueColumns;
            base.DataSource = DataSource;
            base.CNNameColumn = CNNameColumn;
            base.Colors = HistogramColors;
            base.GraphTitle = GraphTitle;
            base.XAxisTitle = XAxisTitle;
            base.YAxisTitle = YAxisTitle;
        }
        /// <summary>
        /// ͼ�����
        /// </summary>
        public override void DrawGraph()
        {
            #region ����ͼ����������
            //x���ϵ���Ŀ��
            int xAxisItemCount = 0;
            //��Ŀ�ϵ�����
            int itemElementCount = 0;

            if (base.XAxisScaleRefrence == DataTableStruct.Rows)
            {
                xAxisItemCount = base.DataSource.Rows.Count;
                itemElementCount = base.ShowValueColumns.Length;
            }
            else
            {
                xAxisItemCount = base.ShowValueColumns.Length;
                itemElementCount = base.DataSource.Rows.Count;
            }



            //X��Ԫ�صı�ǩ
            string[] labels = new string[xAxisItemCount];
            if (base.XAxisScaleRefrence == DataTableStruct.Rows)
            {
                //���X������ȡ���ݱ�ļ�¼��
                for (int i = 0; i < base.DataSource.Rows.Count; i++)
                    labels[i] = base.DataSource.Rows[i][base.CNNameColumn].ToString();
            }
            else
            {
                for (int i = 0; i < base.ShowValueColumns.Length; i++)
                    labels[i] = base.ShowValueColumns[i].ColumnName;
            }
            //ͼ����ʾ��Ҫ��ֵ ,��������,
            //��һ������ΪX���ϵ���Ŀ�ĸ���(X1,X2,X3,X4...),���Ⱥ�labels����һ��
            //�ڶ�������Ϊÿ����Ŀ�ĵ�N��ֵ,����Ϊÿ����Ŀ�ڵ�Ԫ�ظ����� 
            //{F1.Value1,F1.Value1,F3.Value1....} 
            //{F1.Value2,F1.Value2,F3.Value2....} 
            //{F1.Value3,F1.Value3,F3.Value3....} 
            double[][] values = new double[itemElementCount][];
            //�������;
            for (int i = 0; i < itemElementCount; i++)
            {
                values[i] = new double[xAxisItemCount]; //����Ϊ��¼��

                for (int j = 0; j < xAxisItemCount; j++)
                {
                    if (XAxisScaleRefrence == DataTableStruct.Rows)
                    {
                        if (Convert.IsDBNull(base.DataSource.Rows[j][base.ShowValueColumns[i].ColumnField]))
                            values[i][j] = 0;
                        else
                            values[i][j] = Convert.ToDouble(base.DataSource.Rows[j][base.ShowValueColumns[i].ColumnField]);
                    }
                    else
                    {
                        if (Convert.IsDBNull(base.DataSource.Rows[i][base.ShowValueColumns[j].ColumnField]))
                            values[i][j] = 0;
                        else
                            values[i][j] = Convert.ToDouble(base.DataSource.Rows[i][base.ShowValueColumns[j].ColumnField]);
                    }
                }
            }
            //X���·��ı�ǩ
            string[] markText;
            if (base.XAxisScaleRefrence == DataTableStruct.Columns)
            {

                markText = new string[base.DataSource.Rows.Count];
                for (int i = 0; i < base.DataSource.Rows.Count; i++)
                    markText[i] = base.DataSource.Rows[i][CNNameColumn].ToString();
            }
            else
            {
                markText = new string[base.ShowValueColumns.Length];
                for (int i = 0; i < base.ShowValueColumns.Length; i++)
                    markText[i] = base.ShowValueColumns[i].ColumnName;
            }
            #endregion
            //Console.Beep();
            #region ��ʾͼ��
            base.GraphContainer.Controls.Clear();

            ZedGraph.ZedGraphControl grphTx = new ZedGraph.ZedGraphControl();

            grphTx.IsEnableHZoom = false;
            grphTx.IsEnableVZoom = false;
            grphTx.IsEnableWheelZoom = false;
            grphTx.Dock = System.Windows.Forms.DockStyle.Fill;


            ZedGraph.GraphPane myPane = grphTx.GraphPane;
            myPane.Title.Text = base.GraphTitle;
            myPane.XAxis.Title.Text = base.XAxisTitle;
            myPane.YAxis.Title.Text = base.YAxisTitle;

            ////�����ʾ��
            ZedGraph.BarItem bar;

            for (int i = 0; i < values.Length; i++)
            {
                double[] y = values[i];
                bar = myPane.AddBar(markText[i], null, y, Color.Red);
                //��ɫ���û��ָ��,���ȡ
                Color color;
                if (base.Colors == null)
                    color = GetColor();
                else
                    color = base.Colors[i];

                bar.Bar.Fill = new ZedGraph.Fill(color, Color.White, color);
            }

            myPane.XAxis.MajorTic.IsBetweenLabels = true;
            myPane.XAxis.Scale.TextLabels = labels;
            myPane.XAxis.Scale.FontSpec.Angle = 90;
            myPane.XAxis.Scale.FontSpec.Size = 11F;
            myPane.XAxis.Type = ZedGraph.AxisType.Text;
            myPane.Chart.Fill = new ZedGraph.Fill(Color.White, Color.FromArgb(255, 255, 166), 90F);
            myPane.Fill = new ZedGraph.Fill(Color.FromArgb(250, 250, 255));

            grphTx.AxisChange();

            base.GraphContainer.Controls.Add(grphTx);
            #endregion
        }
    }
    /// <summary>
    /// ����ͼ
    /// </summary>
    public class LineGraphControl : GraphControl
    {
        /// <summary>
        /// ʵ��������ͼ
        /// </summary>
        /// <param name="GraphContainer">ͼ����ʾ����Ҫ������</param>
        /// <param name="XAxisScaleRefrence">X��̶Ȳ�������</param>
        /// <param name="ShowValueColumns">��Ҫ��ʾ��ֵ����,�ʹ����DataSource���ж�Ӧ(����ֵ��)</param>
        /// <param name="LineColors">ÿ���ߵ���ɫ������</param>
        /// <param name="DataSource">����Դ</param>
        /// <param name="CNNameColumn">����Դ�е����������е��ֶ���</param>
        public LineGraphControl(System.Windows.Forms.Control GraphContainer,
            DataTableStruct XAxisScaleRefrence, TableColumn[] ShowValueColumns, Color[] LineColors, System.Data.DataTable DataSource,
            string CNNameColumn)
        {
            base.GraphContainer = GraphContainer;
            base.XAxisScaleRefrence = XAxisScaleRefrence;
            base.ShowValueColumns = ShowValueColumns;
            base.Colors = LineColors;
            base.DataSource = DataSource;
            base.CNNameColumn = CNNameColumn;
        }
        /// <summary>
        /// ʵ��������ͼ
        /// </summary>
        /// <param name="GraphContainer">ͼ����ʾ����Ҫ������</param>
        /// <param name="XAxisScaleRefrence">X��̶Ȳ�������</param>
        /// <param name="ShowValueColumns">��Ҫ��ʾ��ֵ����,�ʹ����DataSource���ж�Ӧ(����ֵ��)</param>
        /// <param name="LineColors">ÿ���ߵ���ɫ������</param>
        /// <param name="DataSource">����Դ</param>
        /// <param name="CNNameColumn">����Դ�е����������е��ֶ���</param>
        /// <param name="GraphTitle">ͼ�εı��⣬λ������ͼ�ε����Ϸ�</param>
        public LineGraphControl(System.Windows.Forms.Control GraphContainer,
            DataTableStruct XAxisScaleRefrence, TableColumn[] ShowValueColumns, Color[] LineColors, System.Data.DataTable DataSource,
            string CNNameColumn, string GraphTitle)
        {
            base.GraphContainer = GraphContainer;
            base.XAxisScaleRefrence = XAxisScaleRefrence;
            base.ShowValueColumns = ShowValueColumns;
            base.Colors = LineColors;
            base.DataSource = DataSource;
            base.CNNameColumn = CNNameColumn;
            base.GraphTitle = GraphTitle;
        }
        /// <summary>
        /// ʵ��������ͼ
        /// </summary>
        /// <param name="GraphContainer">ͼ����ʾ����Ҫ������</param>
        /// <param name="XAxisScaleRefrence">X��̶Ȳ�������</param>
        /// <param name="ShowValueColumns">��Ҫ��ʾ��ֵ����,�ʹ����DataSource���ж�Ӧ(����ֵ��)</param>
        /// <param name="LineColors">ÿ���ߵ���ɫ������</param>
        /// <param name="DataSource">����Դ</param>
        /// <param name="CNNameColumn">����Դ�е����������е��ֶ���</param>
        /// <param name="GraphTitle">ͼ�εı��⣬λ������ͼ�ε����Ϸ�</param>
        /// <param name="XAxisTitle">x��ı���</param>
        /// <param name="YAxisTitle">y��ı���</param>
        public LineGraphControl(System.Windows.Forms.Control GraphContainer,
            DataTableStruct XAxisScaleRefrence, TableColumn[] ShowValueColumns, Color[] LineColors, System.Data.DataTable DataSource,
            string CNNameColumn, string GraphTitle, string XAxisTitle, string YAxisTitle)
        {
            base.GraphContainer = GraphContainer;
            base.XAxisScaleRefrence = XAxisScaleRefrence;
            base.ShowValueColumns = ShowValueColumns;
            base.Colors = LineColors;
            base.DataSource = DataSource;
            base.CNNameColumn = CNNameColumn;
            base.GraphTitle = GraphTitle;
            base.XAxisTitle = XAxisTitle;
            base.YAxisTitle = YAxisTitle;
        }
        /// <summary>
        /// ͼ�����
        /// </summary>
        public override void DrawGraph()
        {
            #region ͼ����������
            //��������[������] [ÿ���ߵĿ̶�ֵ]
            double[][] lines;
            //X��̶�
            double[] xAixsScale;
            //������ע
            string[] labels;
            //����̶ȱ�ע
            string[] xAxisScaleLabels;

            if (base.XAxisScaleRefrence == DataTableStruct.Rows)
            {
                xAixsScale = new double[base.DataSource.Rows.Count];
                xAxisScaleLabels = new string[base.DataSource.Rows.Count];
                for (int i = 0; i < base.DataSource.Rows.Count; i++)
                {
                    xAixsScale[i] = i;
                    xAxisScaleLabels[i] = base.DataSource.Rows[i][base.CNNameColumn].ToString();
                }
                //Ҫ���Ƶ�������Ϊ��������
                lines = new double[base.ShowValueColumns.Length][];
                //������ע
                labels = new string[lines.Length];
                for (int i = 0; i < base.ShowValueColumns.Length; i++)
                    labels[i] = base.ShowValueColumns[i].ColumnName;


                //���ÿ���ߵ�����ֵ
                for (int i = 0; i < lines.Length; i++)
                {
                    lines[i] = new double[xAixsScale.Length];
                    for (int j = 0; j < base.DataSource.Rows.Count; j++)
                    {
                        if (Convert.IsDBNull(base.DataSource.Rows[j][base.ShowValueColumns[i].ColumnField]))
                            lines[i][j] = 0;
                        else
                            lines[i][j] = Convert.ToDouble(base.DataSource.Rows[j][base.ShowValueColumns[i].ColumnField]);
                    }
                }
            }
            else
            {
                xAixsScale = new double[base.ShowValueColumns.Length];
                xAxisScaleLabels = new string[base.ShowValueColumns.Length];
                for (int i = 0; i < base.ShowValueColumns.Length; i++)
                {
                    xAixsScale[i] = i;
                    xAxisScaleLabels[i] = base.ShowValueColumns[i].ColumnName;
                }
                //Ҫ���Ƶ�������Ϊ���ݼ��ļ�¼��
                lines = new double[base.DataSource.Rows.Count][];
                //������ע
                labels = new string[lines.Length];
                for (int i = 0; i < base.DataSource.Rows.Count; i++)
                    labels[i] = base.DataSource.Rows[i][base.CNNameColumn].ToString();
                //���ÿ���ߵ�����ֵ
                for (int i = 0; i < lines.Length; i++)
                {
                    lines[i] = new double[xAixsScale.Length];
                    for (int j = 0; j < base.ShowValueColumns.Length; j++)
                    {
                        if (Convert.IsDBNull(base.DataSource.Rows[i][base.ShowValueColumns[j].ColumnField]))
                            lines[i][j] = 0;
                        else
                            lines[i][j] = Convert.ToDouble(base.DataSource.Rows[i][base.ShowValueColumns[j].ColumnField]);
                    }
                }
            }

            int maxXaisxScale = xAixsScale.Length;

            //Console.Beep();

            #endregion

            #region ��ʾͼ��
            base.GraphContainer.Controls.Clear();

            ZedGraph.ZedGraphControl grphTx = new ZedGraph.ZedGraphControl();

            grphTx.IsEnableHZoom = false;
            grphTx.IsEnableVZoom = false;
            grphTx.IsEnableWheelZoom = false;
            grphTx.Dock = System.Windows.Forms.DockStyle.Fill;


            ZedGraph.GraphPane myPane = grphTx.GraphPane;
            myPane.Title.Text = base.GraphTitle;
            myPane.XAxis.Title.Text = base.XAxisTitle;
            myPane.YAxis.Title.Text = base.YAxisTitle;

            myPane.Chart.Fill = new Fill(Color.FromArgb(255, 255, 245), Color.FromArgb(255, 255, 190), 90F);
            //������ʾ
            for (int i = 0; i < lines.Length; i++)
            {
                Color color;
                if (base.Colors == null)
                    color = GetColor();
                else
                    color = base.Colors[i];

                ZedGraph.LineItem myCurve = myPane.AddCurve(labels[i], xAixsScale, lines[i], color);

                myCurve.Symbol.Fill = new Fill(Color.White);
            }

            //X������
            myPane.XAxis.Scale.Min = 0; //X��̶���ʼֵ
            myPane.XAxis.Scale.Max = maxXaisxScale;//X��̶����ֵ
            myPane.XAxis.Scale.TextLabels = xAxisScaleLabels;//x��̶����ı�ע
            myPane.XAxis.Type = AxisType.Text;   //����
            myPane.XAxis.Scale.FontSpec.Angle = 90;��//���ַ���
            myPane.XAxis.Scale.FontSpec.Size = 11F;  //���ִ�С

            // Display the Y axis grid lines
            myPane.YAxis.MajorGrid.IsVisible = true;
            myPane.YAxis.MinorGrid.IsVisible = true;


            BoxObj box = new BoxObj(0, 100, 1, 30, Color.Empty,
            Color.FromArgb(150, Color.LightGreen));
            box.Fill = new Fill(Color.White, Color.FromArgb(200, Color.LightGreen), 45.0F);

            box.ZOrder = ZOrder.E_BehindCurves;

            box.IsClippedToChartRect = true;

            box.Location.CoordinateFrame = CoordType.XChartFractionYScale;
            myPane.GraphObjList.Add(box);

            TextObj text = new TextObj("", 0.95f, 85, CoordType.AxisXYScale,
                                    AlignH.Right, AlignV.Center);
            text.FontSpec.Fill.IsVisible = false;
            text.FontSpec.Border.IsVisible = false;
            text.FontSpec.IsBold = true;
            text.FontSpec.IsItalic = true;
            text.Location.CoordinateFrame = CoordType.XChartFractionYScale;
            text.IsClippedToChartRect = true;

            myPane.GraphObjList.Add(text);

            myPane.Fill = new Fill(Color.WhiteSmoke, Color.Lavender, 0F);

            grphTx.AxisChange();

            base.GraphContainer.Controls.Add(grphTx);
            #endregion
        }
    }
    /// <summary>
    /// ��״ͼ
    /// </summary>
    public class CakyGraphControl : GraphControl
    {
        /// <summary>
        /// ʵ������״ͼ
        /// </summary>
        /// <param name="GraphContainer">ͼ����ʾ���������</param>
        /// <param name="XAxisScaleRefrence">����ɲ��ֵ�������Դ��������Rowʱ��������״ͼ����һ���ֶ�,Index����ָ��DataSource����,��������Columnʱ��������״ͼ�������ݱ��ڵ�һ������,�������ɲ���Indexָ��</param>
        /// <param name="ShowValueColumns">Ҫ��ʾ�ĵ�ֵ����</param>
        /// <param name="PartyColors">ÿ���ֱ�״��ɫ������</param>
        /// <param name="DataSource">����Դ������Ҫ��һ�������к�ֵ��</param>
        /// <param name="CNNameColumn">�����е��ֶ���</param>
        /// <param name="Index">ָ��Ҫ��ʾ���л��е�����(�����DataSource����)</param>
        public CakyGraphControl(System.Windows.Forms.Control GraphContainer, DataTableStruct XAxisScaleRefrence,
            TableColumn[] ShowValueColumns, Color[] PartyColors, System.Data.DataTable DataSource,
            string CNNameColumn, int Index)
        {
            base.GraphContainer = GraphContainer;
            base.Colors = PartyColors;
            base.DataSource = DataSource;
            base.CNNameColumn = CNNameColumn;
            base.XAxisScaleRefrence = XAxisScaleRefrence;
            base.ShowValueColumns = ShowValueColumns;
            index = Index;
        }

        private int index;

        public override void DrawGraph()
        {
            string graphTitle;
            //����ɲ��ֱ�ǩ
            string[] labels = null;
            //����ɲ��ֵ�ֵ
            double[] values = null;
            //�ϼ�
            double total = 0;
            if (base.XAxisScaleRefrence == DataTableStruct.Rows)
            {
                labels = new string[base.DataSource.Rows.Count];
                values = new double[base.DataSource.Rows.Count];

                for (int i = 0; i < base.DataSource.Rows.Count; i++)
                {
                    labels[i] = base.DataSource.Rows[i][base.CNNameColumn].ToString();
                    if (Convert.IsDBNull(base.DataSource.Rows[i][base.ShowValueColumns[index].ColumnField]))
                    {
                        values[i] = 0;
                    }
                    else
                    {
                        values[i] = Convert.ToDouble(base.DataSource.Rows[i][base.ShowValueColumns[index].ColumnField]);
                        total += values[i];
                    }
                }

                graphTitle = base.ShowValueColumns[index].ColumnName;
            }
            else
            {
                labels = new string[base.ShowValueColumns.Length];
                values = new double[base.ShowValueColumns.Length];

                for (int i = 0; i < base.ShowValueColumns.Length; i++)
                {
                    labels[i] = base.ShowValueColumns[i].ColumnName;
                    if (Convert.IsDBNull(base.DataSource.Rows[index][base.ShowValueColumns[i].ColumnField]))
                        values[i] = 0;
                    else
                        values[i] = Convert.ToDouble(base.DataSource.Rows[index][base.ShowValueColumns[i].ColumnField]);

                    total += values[i];
                }
                graphTitle = base.DataSource.Rows[index][base.CNNameColumn].ToString();
            }

            #region ��ʾͼ��
            base.GraphContainer.Controls.Clear();

            ZedGraph.ZedGraphControl grphTx = new ZedGraph.ZedGraphControl();

            grphTx.IsEnableHZoom = false;
            grphTx.IsEnableVZoom = false;
            grphTx.IsEnableWheelZoom = false;
            grphTx.Dock = System.Windows.Forms.DockStyle.Fill;


            ZedGraph.GraphPane myPane = grphTx.GraphPane;
            myPane.Title.Text = graphTitle;
            //����
            //myPane.Title.FontSpec.IsItalic = true;
            //myPane.Title.FontSpec.Size = 24f;
            //myPane.Title.FontSpec.Family = "Verdana";
            myPane.Fill = new Fill(Color.White, Color.Goldenrod, 45.0f);
            myPane.Chart.Fill.IsVisible = false;
            myPane.Legend.Position = LegendPos.Float;
            myPane.Legend.Location = new Location(0.95f, 0.15f, CoordType.PaneFraction, AlignH.Right, AlignV.Top);
            myPane.Legend.FontSpec.Size = 10f;
            myPane.Legend.IsHStack = false;
            //����״����
            for (int i = 0; i < labels.Length; i++)
            {
                Color color;
                if (base.Colors == null)
                    color = GetColor();
                else
                    color = base.Colors[i];

                PieItem segment = myPane.AddPieSlice(values[i], color, color, 45f, 0, labels[i]);
            }

            CurveList curves = myPane.CurveList;

            TextObj text = new TextObj("�ϼ�:\n" + total.ToString(), 0.18F, 0.40F, CoordType.PaneFraction);
            text.Location.AlignH = AlignH.Center;
            text.Location.AlignV = AlignV.Bottom;
            text.FontSpec.Border.IsVisible = false;
            text.FontSpec.Fill = new Fill(Color.White, Color.FromArgb(255, 100, 100), 45F);
            text.FontSpec.StringAlignment = StringAlignment.Center;
            myPane.GraphObjList.Add(text);

            // Create a drop shadow for the total value text item
            TextObj text2 = new TextObj(text);
            text2.FontSpec.Fill = new Fill(Color.Black);
            text2.Location.X += 0.008f;
            text2.Location.Y += 0.01f;
            myPane.GraphObjList.Add(text2);


            grphTx.AxisChange();

            base.GraphContainer.Controls.Add(grphTx);
            #endregion
        }
    }
}
