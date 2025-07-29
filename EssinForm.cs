using System.Text;
using System.Web;
using System.Windows.Forms;

namespace Narthalas
{
    public partial class EssinForm : Form
    {
        public EssinForm()
        {
            InitializeComponent();
            kryptonTextBoxResults.Text = string.Empty;
        }

        private static readonly string[] SilbenAnfang = { "Al", "Bel", "Dar", "El", "Fen", "Gar", "Hal", "Is", "Jon", "Kel", "Lor", "Mar", "Nor", "Or", "Per", "Quin", "Ran", "Sor", "Tor", "Ul", "Val", "Wil", "Xan", "Yor", "Zan" };
        private static readonly string[] SilbenMitte = { "a", "e", "i", "o", "u", "ae", "ia", "ou", "ar", "ir", "or", "ur", "el", "an", "en", "in", "on", "un" };
        private static readonly string[] SilbenEnde = { "dor", "ric", "son", "mir", "tis", "las", "nix", "zor", "ran", "th", "ien", "dus", "var", "len", "mon", "gorn", "rek", "wyn", "dil", "rix" };

        private static readonly Random random = new();

        public static string GenerateName(int silbenAnzahl = 2)
        {
            StringBuilder sb = new();

            _ = sb.Append(SilbenAnfang[random.Next(SilbenAnfang.Length)]);

            for (int i = 0; i < silbenAnzahl - 1; i++)
            {
                _ = sb.Append(SilbenMitte[random.Next(SilbenMitte.Length)]);
            }

            _ = sb.Append(SilbenEnde[random.Next(SilbenEnde.Length)]);

            return sb.ToString();
        }

        public static string GenerateFullName()
        {
            string vorname = GenerateName(random.Next(2, 4));
            string nachname = GenerateName(random.Next(2, 4));
            return $"{vorname} {nachname}";
        }


        private void KryptonButtonStart_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < kryptonNumericUpDownSetResultNames.Value; i++)
            {
                if (string.IsNullOrWhiteSpace(kryptonTextBoxResults.Text))
                {
                    kryptonTextBoxResults.Text = $"{GenerateName()}";
                }
                else
                {
                    kryptonTextBoxResults.Text = $"{kryptonTextBoxResults.Text} {GenerateName()} ";
                }
            }
        }

        private void kryptonButtonOutputOptions_Click(object sender, EventArgs e)
        {
            // Position des Buttons relativ zum Formular
            Point buttonPosition = kryptonButtonOutputOptions.PointToScreen(Point.Empty);

            // Position unterhalb des Buttons berechnen
            Point menuPosition = new Point(buttonPosition.X, buttonPosition.Y + kryptonButtonOutputOptions.Height);

            // Kontextmenü an dieser Position anzeigen
            contextMenuStripResultOptions.Show(menuPosition);
        }

        private void toolStripMenuItemOutputOptionsEntriesLineByLine_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItemOutputOptionsClearListWithEveryGeneration_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItemOutputOptionsSeparatorIsSpace_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItemOutputOptionsSeparatorIsComma_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItemOutputOptionsSeparatorIsPipe_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItemOutputOptionsSeparatorIsSemikolon_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItemOutputOptionsEnclosedWithQuotes_Click(object sender, EventArgs e)
        {

        }
    }
}
