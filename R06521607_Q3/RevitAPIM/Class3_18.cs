using System;
using System.Collections.Generic;
using Autodesk.Revit.UI;
using Autodesk.Revit.DB;
using System.Windows.Media.Imaging;

namespace RevitAPIM
{
	[Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
	public class Class3_18 : IExternalApplication
	{
		string path;
		string filepath;
		static string assembly;
		static string picture;
		public Result OnShutdown(UIControlledApplication application)
		{
			return Result.Succeeded;
		}
		public Result OnStartup(UIControlledApplication application)
		{
			// 尋找檔案在電腦上的路徑
			path =
		   System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase).ToString();
			filepath = path.Substring(6);
			assembly = System.Reflection.Assembly.GetExecutingAssembly().Location;
			picture = filepath + @"\..\..\..\..\picture\";

			String tabName = "王琪驊_期中考(2019)";
			application.CreateRibbonTab(tabName);
			RibbonPanel panel = application.CreateRibbonPanel(tabName, "學號：r06521607 王琪驊");
			AddPushButton(panel);
			return Result.Succeeded;
		}
		private void AddPushButton(RibbonPanel panel)
		{

			PushButton pushButton = panel.AddItem(new PushButtonData("Open_database", "打開資料庫", assembly, "RevitAPIM.Call2ExtApp")) as PushButton;
			pushButton.ToolTip = "打開r06521607視窗，篩選資料庫相關元件";
			//Set the large image shown on button 設定按鈕上顯示的大圖示
			pushButton.LargeImage = new BitmapImage(new Uri(picture + "database32X32.png"));

			PushButton pushButton1 = panel.AddItem(new PushButtonData("Open_Form", "操作模型", assembly,
		   "RevitAPIM.Class3_3")) as PushButton;
			pushButton1.ToolTip = "在Revit下條件篩選元件，使其亮顯";
			//Set the large image shown on button 設定按鈕上顯示的大圖示
			pushButton1.LargeImage = new BitmapImage(new Uri(picture + "操作模型32X32.png"));

			PushButton pushButton2 = panel.AddItem(new PushButtonData("Open_Category", "元件品類", assembly,
		   "RevitAPIM.Class5_2")) as PushButton;
			pushButton2.ToolTip = "查找品類";
			//Set the large image shown on button 設定按鈕上顯示的大圖示
			pushButton2.LargeImage = new BitmapImage(new Uri(picture + "品類32X32.jpg"));
		}

	}
		///直接開啟r06521607.exe
		[Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
		public class Call2ExtApp : IExternalCommand
		{
			public Autodesk.Revit.UI.Result Execute(ExternalCommandData revit, ref string message, ElementSet elements)
			{
				string pa =
			   System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase).ToString();
				string fpath = pa.Substring(6);
				
				System.Diagnostics.Process.Start(fpath + @"\..\..\..\..\R06521607_Q2\r06521607\bin\Debug\r06521607.exe");
				return Autodesk.Revit.UI.Result.Succeeded;
			}
		}

		/// 亮顯所篩選的元件
		[Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
		class Class3_3 : IExternalCommand
		{
			public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
			{
				message = "請注意：有特別亮顯的『牆』元件。";
				FilteredElementCollector collector =
				new FilteredElementCollector(commandData.Application.ActiveUIDocument.Document);
				ICollection<Element> collection = collector.OfClass(typeof(Wall)).ToElements();
				foreach (Element e in collection)
				{
					elements.Insert(e);
				}
				return Result.Failed;
			}
		}

		/// 502  Getting element category
		[Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
		class Class5_2 : IExternalCommand
		{
			public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
			{
				UIDocument uidoc = commandData.Application.ActiveUIDocument;
				//Autodesk.Revit.UI.Selection.SelElementSet selElements = uidoc.Selection.Elements;
				ICollection<ElementId> selectedIds = uidoc.Selection.GetElementIds();
				Element selecteedElement = null;
				foreach (ElementId e in selectedIds)
				{
					selecteedElement = uidoc.Document.GetElement(e);
					break;  // just get one selected element
				}
				// Get the category instance from the Category property[從Category屬性中取得品類的實作元件]
				Category category = selecteedElement.Category;
				BuiltInCategory enumCategory = (BuiltInCategory)category.Id.IntegerValue;
				TaskDialog.Show("王琪驊2019", "您所選取元件的品類名稱為：" + category.Name
							 + "\n其對應的BuiltInCategory的名稱為：" + enumCategory);
				return Result.Succeeded;
			}
		}

	

}
