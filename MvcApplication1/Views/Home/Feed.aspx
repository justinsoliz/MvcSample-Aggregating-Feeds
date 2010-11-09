<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" 
    Inherits="System.Web.Mvc.ViewPage<IEnumerable<Api.FeedItem>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Feed
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Feed
    </h2>
    <div id="activity-stream">
        <% foreach (var feedItem in Model) {%>
        <div class="feed-item <%: feedItem.FeedSource %>">
            <p>
                <%= feedItem.Content %>
                <br />
                <span style="font-family: Times New Roman; font-size: 1em;">&nbsp;-
                    <% if (feedItem.Today) {%>
                    Today at
                    <%: feedItem.DatePosted.ToShortTimeString()%>
                    <% } else {%>
                    <%: String.Format("{0:MMMM d} at {1}", feedItem.DatePosted,
                        feedItem.DatePosted.ToShortTimeString()) %>
                    <%
                        }%>
                </span>
            </p>
        </div>
        <%
            }%>
    </div>
</asp:Content>
