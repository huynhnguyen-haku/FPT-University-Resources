package sample.controller;

import java.io.IOException;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.Cookie;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;
import sample.user.UserDAO;
import sample.user.UserDTO;

@WebServlet(name = "LoginController", urlPatterns = {"/LoginController"})
public class LoginController extends HttpServlet {

    private static final String ERROR = "login.jsp";

    private static final String AD = "AD";
    private static final String ADMIN_PAGE = "admin.jsp";
    private static final String US = "US";
    private static final String USER_PAGE = "user.jsp";

    protected void processRequest(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        response.setContentType("text/html;charset=UTF-8");
        String url = ERROR;
        try {
            String userID = request.getParameter("userID");
            String password = request.getParameter("password");
            boolean rememberMe = request.getParameter("remember-me") != null;
            Cookie[] cookies = request.getCookies();
            
            if (cookies != null) {
                for (Cookie cookie : cookies) {
                    if (cookie.getName().equals("remember-me")) {
                        // Retrieve the value of the remember-me cookie
                        String cookieValue = cookie.getValue();
                        // Split the cookie value into the user ID and password
                        String[] parts = cookieValue.split(":");
                        String userIDCookie = parts[0];
                        String passwordCookie = parts[1];
                        userID = userIDCookie;
                        password = passwordCookie;
                    }
                }
            }
            
            UserDAO dao = new UserDAO();
            UserDTO loginUser = dao.checkLogin(userID, password);
            //Xac thuc o day
            if (userID != null && password != null && loginUser == null) {
                request.setAttribute("ERROR", "Incorrect userID or password");
            } else if (userID == null && password == null && loginUser == null) {
                request.setAttribute("ERROR", "Expired cookie");
            } else {
                //Phan quyen o day
                HttpSession session = request.getSession();
                session.setAttribute("LOGIN_USER", loginUser);
                if (rememberMe) {
                    Cookie rememberMeCookie = new Cookie("remember-me", userID + ":" + password);
                    rememberMeCookie.setMaxAge(24 * 60 * 60); // Set the cookie to expire in 1 days
                    response.addCookie(rememberMeCookie);
                }
                String roleID = loginUser.getRoleID();
                if (AD.equals(roleID)) {
                    url = ADMIN_PAGE;
                } else if (US.equals(roleID)) {
                    url = USER_PAGE;
                } else {
                    request.setAttribute("ERROR", "Your role is not support yet!");
                }
            }

        } catch (Exception ex) {
            log("Error at: MainController" + ex.toString());
        } finally {
            request.getRequestDispatcher(url).forward(request, response);
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
