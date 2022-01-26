using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using NLog;

namespace Exam
{
    public partial class Form1 : Form
    {
        private readonly Logger logger;

        private delegate string FirstMeth();
        private delegate string SecondMeth(int num);

        private event FirstMeth EventFirstMeth;
        private event SecondMeth EventSecondMeth;

        List<IClass> list = new List<IClass>();
        Random random = new Random();
        IClass MyInterface;

        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < random.Next(5, 10); i++)
            {
                list.Add(new FirstClass(random.Next(10, 20)));
            }
            for (int i = 0; i < random.Next(5, 10); i++)
            {
                list.Add(new SecondClass(random.Next(10, 20)));
            }
            foreach (IClass ClassFromList in list)
            {
                listBox.Items.Add(ClassFromList.Name);
            }
            logger = LogManager.GetCurrentClassLogger();
        }

        public void Sort() => list.Sort((IComparer<IClass>)(new Comparer()));

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBoxEnter.Text) < 10)
            {
                MyInterface = new FirstClass(random.Next(10, 20));
            }
            else
            {
                MyInterface = new FirstClass(Convert.ToInt32(textBoxEnter.Text));
            }
        }

        private void buttonFirstMethod_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = MyInterface.Method();
            logger.Info("Вызван первый метод");
        }

        private void buttonSecondMethod_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = MyInterface.Method(Convert.ToInt32(textBoxEnter.Text));
            logger.Info("Вызван второй метод");
        }

        private void buttonAddFirstMeth_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex != -1) 
            {
                IClass someClass = list[listBox.SelectedIndex];
                EventFirstMeth += someClass.Method;
                logger.Info("Привязка к первому событию");
            }
        }

        private void buttonInvokeFirstMeth_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = EventFirstMeth?.Invoke();
            logger.Info("Вызов первого события");
        }

        private void buttonDelFirstMeth_Click(object sender, EventArgs e)
        {
            if (EventFirstMeth != null)
            {
                EventFirstMeth = null;
                logger.Info("Отвязка от первого события");
            }
        }

        private void buttonAddSecondMeth_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex != -1)
            {
                IClass someClass = list[listBox.SelectedIndex];
                EventSecondMeth += someClass.Method;
                logger.Info("Привязка ко второму событию");
            }
        }

        private void buttonInvokeSecodMeth_Click(object sender, EventArgs e)
        {
            int userNum = Convert.ToInt32(textBoxEnter.Text);
            textBoxResult.Text = EventSecondMeth?.Invoke(userNum);
            logger.Info("Вызов второго события");
        }

        private void buttonDelSecondMeth_Click(object sender, EventArgs e)
        {
            if (EventSecondMeth != null)
            {
                EventSecondMeth = null;
                logger.Info("Отвязка от второго события");
            }
        }

        private void SaveData(int userNum)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            
            string filename = saveFileDialog.FileName;            

            using (StreamWriter sw = new StreamWriter(filename, false, Encoding.UTF8))
            {
                foreach (var item in list)
                {
                    sw.WriteLine($"{item.GetType().Name}:{item}.{item.Method()}.{item.Method(userNum)}");
                }
            }

            logger.Info("Список сохранен");
        }
    }
}