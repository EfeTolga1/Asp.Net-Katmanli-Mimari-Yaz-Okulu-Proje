<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="OgrenciListesi.aspx.cs" Inherits="OgrenciListesi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <table class="table table-bordered table-hover">
        <tr>
            <td>Ogrenci ID</td>
            <td>Ogrenci Ad</td>
            <td>Ogrenci Soyad</td>
            <td>Ogrenci Numara</td>
            <td>Ogrenci Sifre</td>
            <td>Ogrenci Fotograf</td>
            <td>Bakiye</td>
            <td>İslemler</td>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                <tr>
                    <td><%#Eval("ID")%></td>
                    <td><%#Eval("Ad")%></td>
                    <td><%#Eval("Soyad")%></td>
                    <td><%#Eval("Numara")%></td>
                    <td><%#Eval("Sifre")%></td>
                    <td><%#Eval("Fotograf")%></td>
                    <td><%#Eval("Bakiye")%></td>
                   <td>
                       <asp:HyperLink NavigateUrl='<%#"~/OgrenciSil.Aspx?OgrID="+ Eval("ID")%>' ID="HyperLink1" CssClass="btn btn-danger" runat="server">Sil</asp:HyperLink>
                       <asp:HyperLink NavigateUrl='<%#"~/OgrenciGuncelle.Aspx?OgrID="+ Eval("ID")%>' ID="HyperLink2" runat="server" CssClass="btn btn-success">Güncelle</asp:HyperLink>
                   </td>
                </tr>
                    </ItemTemplate>
            </asp:Repeater>            
        </tbody>
    </table>
</asp:Content>

