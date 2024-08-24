package main

//O(N)
//O(1)
func minOperations(nums []int, k int) int {

	if len(nums) == 0 {
		return -1
	}

	count := 0

	for i := 0; i < len(nums); i++ {
		if nums[i] < k {
			count = count + 1
		}
	}

	return count

}
