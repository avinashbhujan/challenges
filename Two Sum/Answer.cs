using System;
					
public class TwoSum
{
	/*
	public static void Main()
	{
		int[] arr = new int[]{2,7,11,15};
		int[] result = GetTwoSum(arr,9);
			Console.WriteLine(result.Length);
		for(int i=0;i < result.Length;i++){
			Console.WriteLine(result[i]);
		}
	}
	*/
	//loop the array
	//for each element, target-nums[i] = secondNum e.g 9-2=7, num + x = target
	
	public static int[] GetTwoSum(int[] nums, int target){
		int[] numbersIndices = new int[2];
		
		for(int i = 0; i < nums.Length; i++){
			int secondNumber = target - nums[i]; //9-2=7
			int secondNumberIndex = Array.IndexOf(nums,secondNumber);
			
			if(secondNumberIndex > -1){//secondNumber exists in the array
				numbersIndices[0] = secondNumberIndex;
				numbersIndices[1] = i;
			}
			//if secondNumber does not exist in the array, then nothing to do
		}
		return numbersIndices;
	}
}