using System;
using System.Windows.Forms;

namespace HoraMundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cmbFusosHorarios.Items.Add("Angola - UTC+01:00 - Africa/Angola");
            cmbFusosHorarios.Items.Add("Argentina - UTC-03:00 - America/Buenos Aires");
            cmbFusosHorarios.Items.Add("Australia - UTC+10:00 - Sydnei");
            cmbFusosHorarios.Items.Add("Alemanha - UTC+01:00 - Europe/Berlin");
            cmbFusosHorarios.Items.Add("Canada - UTC-05:00 - Ottawa");
            cmbFusosHorarios.Items.Add("Istambul - UTC+03:00 - Europe/Istanbul");
            cmbFusosHorarios.Items.Add("Chile - UTC-03:00 - Santiago");
            cmbFusosHorarios.Items.Add("França - UTC+01:00 - Europe/Paris");
            cmbFusosHorarios.Items.Add("Colombia - UTC-05:00 - Bogotá");
            cmbFusosHorarios.Items.Add("RepúblicaTcheca - UTC+01:00 - Praga");
            cmbFusosHorarios.Items.Add("Egito - UTC+02:00 - Cairo");
            cmbFusosHorarios.Items.Add("Japão - UTC+09:00 - Toquio");
            cmbFusosHorarios.Items.Add("México - UTC-06:00 - Cidade do México");
            cmbFusosHorarios.Items.Add("ReinoUnido - UTC+00:00 - Londres");
            cmbFusosHorarios.Items.Add("Uruguai - UTC-03:00 - Montevidéu");

            // Ordenar os itens em ordem alfabética
            cmbFusosHorarios.Sorted = true;
            // Adicione mais cidades conforme necessário

            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 1 segundo
            timer.Tick += (sender, e) =>
            {
                lblHoraUTC.Text = $"Hora UTC: {DateTime.UtcNow.ToString("HH:mm:ss")}";
            };
            timer.Start();
        }

        private void cmbFusosHorarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFusosHorarios.SelectedIndex != -1)
            {
                string selectedItem = cmbFusosHorarios.SelectedItem.ToString();
                string[] parts = selectedItem.Split(' ');
                string cidade = parts[0];
                string fusoHorario = parts[2];
                int offset = int.Parse(fusoHorario.Substring(3, 3));
                if (fusoHorario.StartsWith("-"))
                {
                    offset = -offset;
                }

                DateTime horaLocal = DateTime.UtcNow.AddHours(offset);
                DateTime horaBrasilia = DateTime.UtcNow.AddHours(-3); // Fuso de Brasília é UTC-3

                MessageBox.Show($"País: {cidade}\nHora Local: {horaLocal:HH:mm:ss}\nHora UTC: {DateTime.UtcNow:HH:mm:ss}\nHora Brasília: {horaBrasilia:HH:mm:ss}");
            }
        }

    }
}
