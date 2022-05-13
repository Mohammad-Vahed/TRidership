<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="SCRNAseq.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Welcome to T-Ridership:</h2>
    <address>
       T-Ridership is a novel web-based application, 
       based on a hybrid optimized dynamic programming inspired by neural networks algorithm to optimize public transit for safety concerning COVID-19. 
        Two main steps are taken in the analysis: the first is detecting high-density stations by input data normalization, 
        and then, using these results, the T-Ridership tool automatically determines optimal station order to avoid overcrowded transit vehicles. Effectively, 
        our proposed web tool helps public transit be safe to ride under risk of infections by reducing the density of riders on public transit vehicles and trip duration.   &nbsp;</address>
    <address>
        <h2>Getting Run</h2>
        <address>T-Ridership works with two methods; the first method calculates the number of passengers on a route; when we just have passenger statistics in each station without knowing their origin and destination station. In other words, when the only available data is the number of passengers entering and exiting each station, without knowing each passenger’s specific origin and destination and how many stations are traveling by each.
Our second method which is designed to be used by knowing the number of passengers with their specific origin and destination by creating an n × n matrix that n is the number of stations in one route, and contains our input data consisting of the columns, showing the number of passengers exit in different stations from a specific origin, and the rows showing the number of exit passengers from diverse origins but in a particular destination. 
            The last column of the matrix indicates the number of passengers transiting between two continuous stations.</address>
        
       
    <p>
        <asp:Image ID="Image1" runat="server"  ImageUrl="~/images/1.jpg" />
    </p>
        <address>At first, user should choose the number of stations in one route that wants to be reprogrammed and also the capacity of each bus or each train with the social distancing consideration to avoid overcrowded vehicles.</address>
        
        <h4>First Method: run the app without details of passenger statistics.</h4>
    <p>
        &nbsp;</p>
    <p>
        <asp:Image ID="Image2" runat="server" ImageUrl="~/images/2.jpg" />
    </p>
        <address>"Enter" is the total statistics of passengers entering each station 
            and "Exit" is the total statistics of passengers exiting each station,
            and "Transfer" is the total number of passengers transiting between two stations. 
            For example in this given sample, in station 5 twelve passengers are in the vehicle from previous stations 
            and fourteen passengers enter the vehicle and seven people exit the vehicle, and the balance would be twenty-one passengers, and since it exceeds the fixed maximum capacity (twenty passengers), 
            Run1 skips station 5 and the passengers transfer to Run2.
        </address>
   
        <h2>Output:</h2>
        <address>
        <asp:Image ID="Image3" runat="server" ImageUrl="~/images/3.jpg" />
    </address>
    <address>
        <asp:Image ID="Image4" runat="server" ImageUrl="~/images/4.jpg" />
    </address>
        <address>As the output of the T-Ridership, the result is shown as text and also graphical illustration, featuring all stations divided into different runs with their stops and skipped stations, not exceeding the fixed maximum capacity throughout the route.</address></address>



        <h3>Second Method: run the app with details of passenger statistics.</h3>
    <p>
        <asp:Image ID="Image5" runat="server" ImageUrl="~/images/5.jpg" />
    </p>
    <address>Knowing the number of passengers with their specific origin and destination by creating an n × n matrix that n is the number of stations in one route, 
        and contains our input data consisting of the columns, showing the number of passengers exiting in different stations from a specific origin, and the rows showing the number of exit passengers from diverse origins but in a particular destination. 
        The last column of the matrix indicates the number of passengers transiting between two continuous stations.
        For example according to the sample, in station 1, seven passengers entered the transit vehicle, 
        but since station 5 exceeds the fixed maximum capacity, Run1 skips the station 5, and the number of passengers that are going from station 1 to station 5 does not consider in the calculation (one passenger). 
        As the output shows the total number of passengers using Run1 are six. 
        The same process repeats in other stations (passengers entering stations 2, 3, and 4 going to station 5 would be skipped and transferred to Run2).
    </address>
        <strong>Support:</strong>   
    <address>
        <a href="mailto:mvahed@wustl.edu">mvahed@wustl.edu</a> </address>
    <address>
        <a href="mailto:sabaimani@email.arizona.edu">sabaimani@email.arizona.edu</a></address>
    <address>
        &nbsp;</address>
    <address>
        <br />
        </address>
</asp:Content>
