using System;
using System.Xml;

namespace OS_CP.Presenter
{
    /// <summary>
    /// Specific presenter interface for Help view
    /// </summary>
    public sealed class HelpPresenter : BasePresenter<IHelpView>
    {
        /// <summary>
        /// Constructor of AboutPresenter class
        /// </summary>
        /// <param name="controller"> Application controller </param>
        /// <param name="view"> View </param>
        public HelpPresenter(IApplicationController controller, IHelpView view) : base(controller, view)
        {
            View.BasicInfo += () => LoadText("BasicInfo");
            View.LoadingData += () => LoadText("LoadingData");
            View.SavingData += () => LoadText("SavingData");
            View.Export += () => LoadText("Export");
            View.Math += () => LoadText("Math");
            View.ForDevelopers += () => LoadText("ForDevelopers");

            LoadText("BasicInfo");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        private void LoadText(string name)
        {
            XmlDocument help = new XmlDocument();
            help.Load("C:\\Users\\nikit\\source\\repos\\OS\\5th term\\OS_CP\\OS_CP.Presenter\\Help.xml");
            XmlNode helpNode = help.GetElementsByTagName(name)[0];
            XmlNode node = helpNode.FirstChild;
            View.TextInfo = node.InnerText;
        }
    }
}