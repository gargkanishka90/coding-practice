namespace ScratchPad.DesignPatterns.Strategy
{
    public interface IBillingStrategy
 {
     double GetActPrice(double rawPrice);
 }
 
 // Normal billing strategy (unchanged price)
 public class NormalStrategy : IBillingStrategy
 {
     public double GetActPrice(double rawPrice)
     {
         return rawPrice;
     }
 
 }
 
 // Strategy for Happy hour (50% discount)
 public class HappyHourStrategy : IBillingStrategy
 {
 
     public double GetActPrice(double rawPrice)
     {
         return rawPrice* 0.5;
     }
 }
}