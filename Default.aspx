<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SCRNAseq._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Public Transportion Ridership</h1>
        <p class="lead">T-Ridership is a free web server for reprogramming public transportation fleet to reduce Covid-19 infection transmission by social distancing consideration.</p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Getting started</h2>
            <p>
                User can choose the number of stations wants to be analyzed and the capacity of each vehicle between two stations considering social distancing accuracy.</p>
            <p>
                The first method works by input each station entering and exiting passengers statistics.</p>
            <p>
                The second method works with input each passenger specific origin and destination.</p>
            
        </div>
        <div class="col-md-4">
            <h2>Download</h2>
            <p>
                You can access to Github server (Mohammad-Vahed/T_Ridership) to download and run by visual studio.</p>
            
        </div>
        <div class="col-md-4">
            <h2>T-Ridership Releases</h2>
            <p>
                The T-Ridership container is available under a limited, non-commercial use license. Permission to use, copy, modify, and distribute any part of this software for educational, research and non-profit purposes, and without a fee. </p>
            
        </div>
    </div>

</asp:Content>
