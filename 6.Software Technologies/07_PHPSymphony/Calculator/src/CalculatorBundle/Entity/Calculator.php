<?php
namespace CalculatorBundle\Entity;

class Calculator
{
    /**
     * @var float
     */
   private $leftOperand;
    /**
     * @var float
     */
   private $rightOperand;

    /**
     * @return float
     */
    public function getLeftOperand()
    {
        return $this->leftOperand;
    }

    /**
     * @param float $leftOperand
     */
    public function setLeftOperand($leftOperand)
    {
        $this->leftOperand = $leftOperand;
    }
    /**
     * @var string
     */
   private $operator;

//  public function __construct($leftOperand,$rightOperand,$operator)
//  {
//      $this->leftOperand=$leftOperand;
//      $this->rightOperand=$rightOperand;
//      $this->operator=$operator;
//  }

    /**
     * @return string
     */
    public function getOperator()
    {
        return $this->operator;
    }

    /**
     * @param string $operator
     */
    public function setOperator($operator)
    {
        $this->operator = $operator;
    }

    /**
     * @return float
     */
    public function getRightOperand()
    {
        return $this->rightOperand;
    }

    /**
     * @param float $rightOperand
     */
    public function setRightOperand($rightOperand)
    {
        $this->rightOperand = $rightOperand;
    }

    public function calculateResult(){
        $result=0;

        switch ($this->operator){
            case"+":
                $result = $this->leftOperand + $this->rightOperand;
                break;
            case"-":
                $result = $this->leftOperand - $this->rightOperand;
                break;
            case"*":
               $result = $this->leftOperand * $this->rightOperand;
               break;
            case"/":
               $result = $this->leftOperand / $this->rightOperand;
               break;
        }

        return $result;
    }
}