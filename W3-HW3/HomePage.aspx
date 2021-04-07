<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="HW3.HomePage" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    <div class="homepage" id="hp">
        <video src="Utilityfile/Shawn%20Mendes%20Camila%20Cabello%20%20Señorita%20l%20CM%20Choreography_1080p.mp4" controls="controls" autoplay muted loop/>




        <%--<script async src="https://www.youtube.com/iframe_api"></script>
        <script>
            function onYouTubeIframeAPIReady() {
                var player;
                player = new YT.Player('hp', {
                    videoId: 'bZpFN8eFSf0', // YouTube 影片ID
                    width: 800, // 播放器寬度 (px)
                    height: 600, // 播放器高度 (px)
                    playerVars: {
                        autoplay: 1, // 在讀取時自動播放影片
                        controls: 1, // 在播放器顯示暫停／播放按鈕
                        showinfo: 0, // 隱藏影片標題
                        modestbranding: 1, // 隱藏YouTube Logo
                        loop: 1, // 讓影片循環播放
                        fs: 0, // 隱藏全螢幕按鈕
                        cc_load_policty: 0, // 隱藏字幕
                        iv_load_policy: 3, // 隱藏影片註解
                        autohide: 0 // 當播放影片時隱藏影片控制列
                    },
                    events: {
                        onReady: function (e) {
                            e.target.playVideo();
                        }
                    }
                });
            }
        </script>--%>

    </div>
</asp:Content>
