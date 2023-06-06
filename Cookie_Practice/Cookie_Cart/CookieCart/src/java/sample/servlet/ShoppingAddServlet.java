/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package sample.servlet;

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
@WebServlet(name = "ShoppingAddServlet", urlPatterns = {"/ShoppingAddServlet"})
public class ShoppingAddServlet extends HttpServlet {

    final private String shoppingPage = "shopcookie.html";
    
    protected void processRequest(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        response.setContentType("text/html;charset=UTF-8");
        PrintWriter out = response.getWriter();
        try {
           String title = request.getParameter("cmbBook");
            Cookie[] cookies = request.getCookies();
            if(cookies==null){
                Cookie cookie = new Cookie(title, "1");
                cookie.setMaxAge(60*5);
                response.addCookie(cookie);
            }else{
                boolean bFound = false;
                for(int i = 0; i < cookies.length;i++){
                    if(cookies[i].getName().equals(title)){
                        bFound = true;
                        String value = cookies[i].getValue();
                        int quantity = Integer.parseInt(value) + 1;
                        Cookie cookie = new Cookie(title, String.valueOf(quantity));
                        cookie.setMaxAge(60*5);
                        response.addCookie(cookie);
                        break;
                    }
                }
                if(!bFound){
                    Cookie cookie = new Cookie(title, "1");
                    cookie.setMaxAge(60*5);
                    response.addCookie(cookie);
                }
            }
            response.sendRedirect(shoppingPage);
        }finally{
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
