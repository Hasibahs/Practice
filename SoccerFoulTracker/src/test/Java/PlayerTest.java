import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;
import static org.junit.jupiter.api.Assertions.*;

class PlayerTest {
    private Player player;

    @BeforeEach
    void setUp() {
        player = new Player("John Doe");
    }

    @Test
    void testAddYellowCard() {
        player.addCard("YELLOW");
        assertEquals(1, player.getCardCount("YELLOW"));
    }

    @Test
    void testAddRedCard() {
        player.addCard("RED");
        assertEquals(1, player.getCardCount("RED"));
    }

    @Test
    void testAddBlackCard() {
        player.addCard("BLACK");
        assertTrue(player.isDisqualified());
    }

    // Here you can add more tests for other functionalities of the Player class
    // ...
}
