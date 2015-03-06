using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Webservices;

public partial class VerseManage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            GridDataBind();
        }


    }

    private void GridDataBind()
    {
        GridView1.DataSource = Verse.BLL.VerseData.GetAllVerse();
        GridView1.DataBind();
    }

    protected void OnPaging(object sender, GridViewPageEventArgs e)
    {
        throw new NotImplementedException();
    }

    protected void EditRow(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        GridDataBind();
    }

    protected void UpdateRow(object sender, GridViewUpdateEventArgs e)
    {
        String date = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("editVerseDate")).Text;
        String english = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("editVerseEnglish")).Text;
        String arabic = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("editVerseArabic")).Text;

        Verse.BLL.VerseData.Edit((int)e.Keys[0], date, english, arabic);
        GridView1.EditIndex = -1;
        GridDataBind();
    }

    protected void CancelEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
        GridDataBind();
    }

    protected void DeleteRow(object sender, EventArgs e)
    {
        LinkButton lnkRemove = (LinkButton)sender;
        int id = Convert.ToInt32(lnkRemove.CommandArgument);
        Verse.BLL.VerseData.Delete(id);
        GridDataBind();
    }

    protected void AddNewRow(object sender, EventArgs e)
    {

        String date = ((TextBox)GridView1.FooterRow.FindControl("txtVerseDate")).Text;
        String englisg = ((TextBox)GridView1.FooterRow.FindControl("txtverseEnglish")).Text;
        String arabic = ((TextBox)GridView1.FooterRow.FindControl("txtverseArabic")).Text;

        Verse.BLL.VerseData.AddNew(date, englisg, arabic);
        GridDataBind();

    }
}