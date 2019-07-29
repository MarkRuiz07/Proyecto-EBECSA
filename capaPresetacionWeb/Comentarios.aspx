<%@ Page Title="" Language="C#" MasterPageFile="~/Maqueta.Master" AutoEventWireup="true" CodeBehind="Comentarios.aspx.cs" Inherits="capaPresetacionWeb.Comentarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GVcomentarios" runat="server"
     AutoGenerateColumns="False"
     CssClass="table table-bordered bs-table"
     DataKeyNames="idcomentario"
   
     OnRowEditing="GVcomentarios_RowEditing"
     OnRowCancelingEdit="GVcomentarios_RowCancelingEdit"
     OnRowUpdating="GVcomentarios_RowUpdating"
     OnRowDeleting="GVcomentarios_RowDeleting"
    OnDataBound="GVcomentarios_DataBound"
    
     AllowPaging="true">

    <HeaderStyle BackColor="#337ab7" Font-Bold="false" ForeColor="White" />
    <EditRowStyle BackColor="#ffffcc" />
    <EmptyDataRowStyle ForeColor="Red" CssClass="table table-bordered" />
    <EmptyDataTemplate>No hay datos para mostrar!</EmptyDataTemplate> 

        <Columns>
        <%--botones de acción sobre los registros...--%>
            <asp:TemplateField ItemStyle-HorizontalAlign="Center" HeaderStyle-Width="200px">
                <ItemTemplate>
                    <%--Botones de eliminar y editar...--%>
                    <asp:Button ID="btnDelete" runat="server" Text="Borrar" CssClass="btn btn-danger" CommandName="Delete" />
                    <asp:Button ID="btnEdit" runat="server" Text="Editar" CssClass="btn btn-info" CommandName="Edit"/>
                </ItemTemplate>
                <edititemtemplate>
                    <%--Botones de guardar y cancelar la edición de registro...--%>
                    <asp:Button ID="btnUpdate" runat="server" Text="Guardar" CssClass="btn btn-success" CommandName="Update" />
                    <asp:Button ID="btnCancel" runat="server" Text="Cancelar" CssClass="btn btn-default" CommandName="Cancel" />
                </edititemtemplate>
                <ItemStyle HorizontalAlign="Center"></ItemStyle>
            </asp:TemplateField>

            <%--campos no editables...--%>
            <asp:BoundField DataField="idcomentario" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="idcomentario" ControlStyle-Width="70px" >
             <ControlStyle Width="70px"></ControlStyle>
            </asp:BoundField>
            
            <%--campos editables...--%>
            
            <asp:TemplateField HeaderText="Nombres" HeaderStyle-Width="100px">
                <ItemTemplate>
                    <asp:Label ID="lblnombres" runat="server"><%#Eval("nombres") %></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="Txtnombres" runat="server" Text=<%# Bind("nombres")%> CssClass="form-control" ></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>
                        <asp:TemplateField HeaderText="Mensaje" HeaderStyle-Width="100px">
                <ItemTemplate>
                    <asp:Label ID="lblmensaje" runat="server"><%#Eval("mensaje") %></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="Txtmensaje" runat="server" Text=<%# Bind("mensaje")%> CssClass="form-control" ></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>

            <%--campos no editables...--%>
            <asp:BoundField DataField="correo" HeaderText="Correo" InsertVisible="False" ReadOnly="True" SortExpression="Correo"  ></asp:BoundField>

            <asp:BoundField DataField="telefono" HeaderText="Telefono" InsertVisible="False" ReadOnly="True" SortExpression="Telefono" ></asp:BoundField>

           </Columns>
       
    </asp:GridView>
    <asp:Label ID="lblmensaje" runat="server" Text=""></asp:Label>
    <p style="text-align:center;">
        
    </p>
</asp:Content>
