package main

// O(N+M)
// O(1)

// If your matrix does not have a specific order or you do not know its structure, use the nested loops method. N * M
// If the rows of your matrix are sorted, the method starting from the top right corner. N + M

func countNegatives(grid [][]int) int {
	count := 0
	row, col := len(grid), len(grid[0])
	i, j := 0, col-1

	for i < row && j >= 0 {
		if grid[i][j] < 0 {
			count += row - i
			j--
		} else {
			i++
		}
	}
	return count
}
