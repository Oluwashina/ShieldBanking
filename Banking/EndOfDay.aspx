
<%@ Page Title="End Of Day" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EndOfDay.aspx.vb" Inherits="Banking._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <script type="text/javascript">
        function RunEOD() {
            if (Page_IsValid) {
                var updateProgress = $find("<%= UpdateProgress1.ClientID %>");
        window.setTimeout(function () {
            updateProgress.set_visible(true);
        }, 100);
    }
}
  </script>

   
    <div class="text-center mt-5">
        <h4 style="font-weight: bold;">End Of Day Processing</h4>
        <p>This provides a means for end of day processing.</p>
    </div>

    
    <div class="row justify-content-center">
        <div class="col-lg-6">
            
            <div class="mt-3">
                <asp:Calendar style="width: 100%;" ID="CalendarNext" runat="server"></asp:Calendar>
            </div>

              <div class="row">
                <div class="col-lg-12">
                    <div class="form-group mt-3" style="">
                        <label>Next Working Date</label>
                          <asp:TextBox ID="TxtNextWorkingDate" runat="server" class="form-control input-style" ReadOnly="True"></asp:TextBox>
                          <input id="ButOK" onclick="RunEOD()" class="btn btn-primary mt-2" style="visibility:hidden" type="button" value="OK" __designer:mapid="db" disabled="disabled" />
                        </div>
                    </div>
               </div>

              <asp:UpdateProgress ID="UpdateProgress1" runat="server">
            </asp:UpdateProgress>


        </div>
    </div>

    <div class="text-center mt-1 mb-3">
                <asp:Button ID="ButOKo" runat="server" class="btn btn-outline-primary mr-2"  Text="OK"  />
                     <asp:Button ID="ButClose" runat="server" class="btn btn-outline-primary mr-2"  Text="Close"  />
        </div>

    

</asp:Content>

