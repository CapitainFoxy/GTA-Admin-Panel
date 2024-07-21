import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

public class DatabaseConnector {
    private ServerConfig config;

    public DatabaseConnector(ServerConfig config) {
        this.config = config;
    }

    public Connection connect() throws SQLException {
        return DriverManager.getConnection(config.getDbURL(), config.getDbUsername(), config.getDbPassword());
    }
}
