<%-- 
    Document   : user
    Created on : Sep 29, 2022, 7:55:55 AM
    Author     : Acer
--%>

<%@page import="sample.user.UserDTO"%>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>User Page</title>
    </head>
    <body>
        <%
            UserDTO user = (UserDTO) session.getAttribute("LOGIN_USER");
            if (user == null || !"US".equals(user.getRoleID())) {
                response.sendRedirect("login.html");
                return;
            }

        %>
        <h1>User Information</h1>
        <br>User ID của bạn là: <%= user.getUserID()%></br>
        <br>Họ tên đầy đủ: <%= user.getFullName()%></br>
        <br>Role của bạn là: <%= user.getRoleID()%></br>
    </body>
    <form action="MainController">
        <input type ="submit" name ="action" value ="Logout"/>
    </form>
</html>
