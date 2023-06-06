package sample.servlet;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

import java.io.IOException;
import java.io.PrintWriter;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.Cookie;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 *
 * @author MSI AD
 */
@WebServlet(name = "ShoppingViewServlet",urlPatterns = {"/ShoppingViewServlet"})
public class ShoppingViewServlet extends HttpServlet {

    protected void processRequest(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        response.setContentType("text/html;charset=UTF-8");
        PrintWriter out = response.getWriter();
        try {
            Cookie[] cookies = request.getCookies();
            if (cookies != null) {

                out.println("<html>");
                out.println("<head>");
                out.println("<title>Shopping</title>");
                out.println("</head>");
                out.println("<body>");
                out.println("<h1>Your Shopping Cart</h1>");
                out.println("<table border = '1'>");
                out.println("<tr>");
                out.println("<th>No.</th>");
                out.println("<th>Book title</th>");
                out.println("<th>Quantity</th>");
                out.println("<th>Action</th>");
                out.println("<tr>");
                out.println("<form action = 'ShoppingServlet'>");
                int count = 1;
                for (int i = 0; i < cookies.length; i++) {
                    int tmp = Integer.parseInt(cookies[i].getValue());
                    if (tmp > 0) {
                        out.println("<tr>");
                        out.println("<td>" + count++ + "</td>");
                        out.println("<td>" + cookies[i].getName() + "</td>");
                        out.println("<td>" + cookies[i].getValue() + "</td>");
                        out.println("<td><input type= 'checkbox' name='cmbDelete' value='" + cookies[i].getName() + "'/></td>");
                        out.print("</tr>");
                    }
                }
                out.println("<tr>");
                out.println("<td colspan='3'><a href='shopcookie.html'>Add More Cart</a></td>");
                out.println("<td><input type='submit' value='Remove Cart' name='action'/></td>");
                out.print("</tr>");
                out.print("</form>");
                out.print("</table>");
                out.println("</body>");
                out.println("</html>");
                return;
            }
            out.println("<h2>Cart is removed or No items in cart</h2>");

        } finally {
            out.close();
        }
    }

    // <editor-fold defaultstate="collapsed" desc="HttpServlet methods. Click on the + sign on the left to edit the code.">
    /**
     * Handles the HTTP <code>GET</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
    }

    /**
     * Handles the HTTP <code>POST</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
    }

    /**
     * Returns a short description of the servlet.
     *
     * @return a String containing servlet description
     */
    @Override
    public String getServletInfo() {
        return "Short description";
    }// </editor-fold>

}
