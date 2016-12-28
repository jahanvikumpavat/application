using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for bal
/// </summary>
public class bal
{
	public bal()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public int country_id { get; set; }
    public string  country_name { get; set; }
    public int state_id { get; set; }
    public string state_name { get; set; }
    public int refcountry_id { get; set; }
    public Boolean isactivecountry { get; set; }
}