﻿// Copyright © Jürgen Bäurle, http://www.parago.de
// This code released under the terms of the Microsoft Public License (MS-PL)

using System.Runtime.InteropServices;
using System.Windows.Forms;
using ExcelDna.Integration;
using ExcelDna.Integration.CustomUI;

namespace PMStockQuote
{
	[ComVisible(true)]
	public class Ribbon : ExcelRibbon
	{
		public void OnUpdateButtonClick(IRibbonControl control)
		{
			var excel = (Microsoft.Office.Interop.Excel.Application)ExcelDnaUtil.Application;
			
			excel.CalculateFull();
		}

		public void OnAboutButtonClick(IRibbonControl control)
		{
			MessageBox.Show("To retrieve stock quotes or foreign-exchange rates see the following formula samples:\n\n\t=PSQ(A1;\"PRICE\") or just =PSQ(A1)\n\t=PSQ(A1;\"DATE\") ==> EST Time\n\t=PSQ(A1;\"DATELOCAL\")\n\t=PSQ(A1;\"TIME\") ==> EST Time\n\t=PSQ(A1;\"TIMELOCAL\")\n\t=PSQ(A1;\"NAME\")\n\n\t=PFX(A1;\"RATE\") or just =PFX(A1)\n\t=PFX(A1;\"DATE\") ==> EST Time\n\t=PFX(A1;\"DATELOCAL\")\n\t=PFX(A1;\"TIME\") ==> EST Time\n\t=PFX(A1;\"TIMELOCAL\")\n\t=PFX(A1;\"NAME\")\n\nThe PMStockQuote Add-In is developed by Jürgen Bäurle, http://www.parago.de.\n\n", "PMStockQuote Add-In", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
