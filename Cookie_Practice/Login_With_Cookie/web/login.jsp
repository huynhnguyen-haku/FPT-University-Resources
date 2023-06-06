<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>Login Page</title>
    </head>
    <body>
        <form action="MainController" method="POST">
            User ID<input type="text" name="userID" required=""/></br>
            Password<input type="password" name="password" required=""/><br/>
            <label>
                <input type="checkbox" name="remember-me"> Remember me
            </label><br>
            <input type="submit" name="action" value="Login"/>
            <input type="reset" value="Reset"/></br>
            <a href="create.jsp">Create user</a></br>
            <a href="shopping.jsp">Shopping</a></br>
        </form>
        <h1>${requestScope.ERROR}</h1>
    </body>
</html>
