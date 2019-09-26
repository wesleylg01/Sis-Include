internal class InsetForms
{
	public struct INSET_RECT
	{
		public int InSetLeft;
		public int InSetTop;
		public int InSetRight;
		public int InSetBottom;
	}

	public const short HWND_TOP = 0;
	public const int WS_CHILD = 0X40000000;
	public const short GWL_HWNDPARENT = (-8);
	public const short GWL_STYLE = (-16);
    public const short SWP_NOSIZE = 0X1;
    public const short SWP_NOMOVE = 0X2;
	public const short SWP_NOACTIVATE = 0X10;
	public const short SWP_NOZORDER = 0X4;
	public const short SWP_SHOWWINDOW = 0X40;


	[System.Runtime.InteropServices.DllImport("USER32", EntryPoint="GetClientRect", ExactSpelling=true, CharSet=System.Runtime.InteropServices.CharSet.Ansi, SetLastError=true)]
	public static extern int GetClientRect(int hwnd, ref INSET_RECT lpRect);
	[System.Runtime.InteropServices.DllImport("USER32", EntryPoint="GetWindowLongA", ExactSpelling=true, CharSet=System.Runtime.InteropServices.CharSet.Ansi, SetLastError=true)]
	public static extern int GetWindowLong(int hwnd, int nIndex);
	[System.Runtime.InteropServices.DllImport("USER32", EntryPoint="SetWindowLongA", ExactSpelling=true, CharSet=System.Runtime.InteropServices.CharSet.Ansi, SetLastError=true)]
	public static extern int SetWindowLong(int hwnd, int nIndex, int dwNewLong);
	[System.Runtime.InteropServices.DllImport("USER32", EntryPoint="GetParent", ExactSpelling=true, CharSet=System.Runtime.InteropServices.CharSet.Ansi, SetLastError=true)]
	public static extern int GetParent(int hwnd);
	[System.Runtime.InteropServices.DllImport("USER32", EntryPoint="SetParent", ExactSpelling=true, CharSet=System.Runtime.InteropServices.CharSet.Ansi, SetLastError=true)]
	public static extern int SetParent(int hWndChild, int hWndNewParent);
	[System.Runtime.InteropServices.DllImport("USER32", EntryPoint="SetWindowPos", ExactSpelling=true, CharSet=System.Runtime.InteropServices.CharSet.Ansi, SetLastError=true)]
	public static extern int SetWindowPos(int hwnd, int hWndInsertAfter, int X, int Y, int cX, int cY, int wFlags);
	private static INSET_RECT rctRect;


	public static void InsetForm(ref System.Windows.Forms.Form ChildForm, int InsetHWnd)
	{

		
		int lngStyle = 0;

		//ChildForm must be initialized; if it isn't, initialize with 
		//ChildForm.Hide()

		//Change style to child window, set ChildForm's parent, set parent hWnd
		lngStyle = GetWindowLong(ChildForm.Handle.ToInt32(), GWL_STYLE) | WS_CHILD;
		SetWindowLong(ChildForm.Handle.ToInt32(), GWL_STYLE, lngStyle);
		SetParent(ChildForm.Handle.ToInt32(), InsetHWnd);
		SetWindowLong(ChildForm.Handle.ToInt32(), GWL_HWNDPARENT, InsetHWnd);

		//Get dimensions of the inset area
		GetClientRect(InsetHWnd, ref rctRect);

		//Show the inset ChildForm
		SetWindowPos(ChildForm.Handle.ToInt32(), HWND_TOP, 0, 0, rctRect.InSetRight, rctRect.InSetBottom, SWP_NOZORDER | SWP_NOACTIVATE | SWP_SHOWWINDOW);

		//end revision

	}
}