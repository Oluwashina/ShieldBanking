Partial Class ProfitLoss
    Inherits System.Web.UI.Page

    Protected Sub ButClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButClose.Click
        Response.Redirect("welcome.aspx")
    End Sub
End Class
