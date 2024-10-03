/*دلایل ریفکتور
 *تعدد کارها در متد play
 * بهبود در شرط while
 * بهتر است متد خروجی داشته باشد play
 * بهتر است متد پلی دارای datatype  باشد از نوع enum
 */
using _79_Refactor_RandomGame;
randomGenerator randomGenerator=new randomGenerator(new Random());
Game game=new Game(randomGenerator);

var result=game.play();
Game.PrintResultMessage(result);

Console.ReadLine();
