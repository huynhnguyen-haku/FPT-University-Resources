/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package session;

import java.io.IOException;
import java.io.PrintWriter;
import java.text.DateFormat;
import java.util.Date;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

/**
 *
 * @author TranPhu
 */
public class Checksession extends HttpServlet {

    /**
     * Processes requests for both HTTP <code>GET</code> and <code>POST</code>
     * methods.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    protected void processRequest(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        response.setContentType("text/html;charset=UTF-8");
       PrintWriter out = response.getWriter();
        try  {
            /* TODO output your page here. You may use following sample code. */
            out.println("<!DOCTYPE html>");
            out.println("<html>");
            out.println("<head>");
            out.println("<title>Session</title>");            
            out.println("</head>");
            out.println("<body>");
            out.println("<h1>HTTPSession Intergace Demo</h1>");
            HttpSession session = request.getSession(true);
            String heading;
            Integer accessCount = (Integer) session.getAttribute("accessCOunt");
            if(accessCount == null){
                accessCount = new Integer(0);
                heading = "Welcome Session Tracking";
            }else{
            heading = "Comeback";
            accessCount = new Integer(accessCount.intValue() + 1);
            }
            DateFormat formatter = DateFormat.getDateTimeInstance(
            DateFormat.MEDIUM, DateFormat.MEDIUM);
            out.print("<H1 ALIGN = \"CENTER\">" + heading +
                    "</H1>\n<H2>Information on Session: </H2>\n"
                    + "<TABLE BORDER=1 ALIGN=\"CENTER\">\n<TR BFCOLOR="
                    + "\"#FFAD00\">\n <TH>Info Type <TH>Value\n"
                    + "<TR>\n <TD>ID\n <TD>" + session.getId() +
                    "\n<TR>\n <TD>Create time\n <TD>"
                    + new Date(session.getCreationTime())+
                    "\n<TR>\n <TD>Time of Last Access\n <TD>"
                    + new Date(session.getLastAccessedTime()) +
                    "\n<TR>\n <TD>Number of Previous Access\n <TD>" 
                    + accessCount + "\n<TR>\n <TD>Session Time out\n <TD>" +
                    session.getMaxInactiveInterval()
                    + "<TABLE\n</BODY></HTML>");
                    session.setAttribute("accessCount", accessCount);
            out.println("</body>");
            out.println("</html>");
    
        }finally{
            out.close();;
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

