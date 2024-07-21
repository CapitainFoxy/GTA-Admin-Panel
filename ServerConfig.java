import org.w3c.dom.Document;
import org.w3c.dom.Element;
import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;
import java.io.File;

public class ServerConfig {
    private static final String CONFIG_FILE = "config.xml";

    private String dbURL;
    private String dbUsername;
    private String dbPassword;
    private int serverPort;
    private int maxConnections;
    private String logLevel;
    private String logFile;

    public ServerConfig() {
        loadConfig();
    }

    private void loadConfig() {
        try {
            File file = new File(CONFIG_FILE);
            DocumentBuilderFactory dbFactory = DocumentBuilderFactory.newInstance();
            DocumentBuilder dBuilder = dbFactory.newDocumentBuilder();
            Document doc = dBuilder.parse(file);
            doc.getDocumentElement().normalize();

            Element dbElement = (Element) doc.getElementsByTagName("Database").item(0);
            dbURL = dbElement.getElementsByTagName("URL").item(0).getTextContent();
            dbUsername = dbElement.getElementsByTagName("Username").item(0).getTextContent();
            dbPassword = dbElement.getElementsByTagName("Password").item(0).getTextContent();

            Element serverElement = (Element) doc.getElementsByTagName("Server").item(0);
            serverPort = Integer.parseInt(serverElement.getElementsByTagName("Port").item(0).getTextContent());
            maxConnections = Integer.parseInt(serverElement.getElementsByTagName("MaxConnections").item(0).getTextContent());

            Element logElement = (Element) doc.getElementsByTagName("Logging").item(0);
            logLevel = logElement.getElementsByTagName("LogLevel").item(0).getTextContent();
            logFile = logElement.getElementsByTagName("LogFile").item(0).getTextContent();

        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    // Getters and setters...
}
