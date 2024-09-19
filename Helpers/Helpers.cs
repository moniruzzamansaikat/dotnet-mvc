namespace Helpers {
  public class Helpers {
    public static Boolean ActiveLink(string currentAction, string linkAction) {
      return currentAction.Equals(linkAction, StringComparison.OrdinalIgnoreCase);
    }
  }
}