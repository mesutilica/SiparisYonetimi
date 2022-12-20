<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Slider.ascx.cs" Inherits="SiparisYonetimi.WebFormsUI.Moduller.Slider" %>

<div id="myCarousel" class="carousel slide" data-bs-ride="carousel">
    <div class="carousel-indicators">
        <button type="button" data-bs-target="#myCarousel" data-bs-slide-to="0" class="active" aria-label="Slide 1" aria-current="true"></button>
        <button type="button" data-bs-target="#myCarousel" data-bs-slide-to="1" aria-label="Slide 2" class=""></button>
        <button type="button" data-bs-target="#myCarousel" data-bs-slide-to="2" aria-label="Slide 3" class=""></button>
    </div>
    <div class="carousel-inner">

        <asp:Repeater ID="rptSlider" runat="server">
            <ItemTemplate>
                <div class="carousel-item">
                    <img src="/Img/Slides/<%#Eval("Image") %>" class="img-fluid" />

                    <div class="container">
                        <div class="carousel-caption">
                            <h1><%#Eval("Title") %></h1>
                            <p><%#Eval("Description") %></p>
                            <p><a class="btn btn-lg btn-primary" href="<%#Eval("Link") %>">İncele</a></p>
                        </div>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
        
    </div>
    <button class="carousel-control-prev" type="button" data-bs-target="#myCarousel" data-bs-slide="prev">
        <span class="carousel-control-prev-icon" aria-hidden="true"></span>
        <span class="visually-hidden">Previous</span>
    </button>
    <button class="carousel-control-next" type="button" data-bs-target="#myCarousel" data-bs-slide="next">
        <span class="carousel-control-next-icon" aria-hidden="true"></span>
        <span class="visually-hidden">Next</span>
    </button>
</div>

<script src="/Scripts/jquery-3.6.1.min.js"></script>
<script>
    $(".carousel-inner .carousel-item:first-child").addClass("active");
</script>
