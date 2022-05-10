using System;

public static class Methods
{
	public static ItemObject TryFindDataItem(string ID)
	{
		if (Data.dataItems.Exists(item => item.ID == ID))
			return Data.dataItems.Find(item => item.ID == ID);
		else
			return new MiscItem(ID, $"ErrorID \"{ID}\"", null, 0);
	}
}
