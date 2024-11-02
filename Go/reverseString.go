package main

//O(N)
//O(1)
func reverseString(s []byte) {
	if len(s) == 0 {
		return
	}

	L := 0
	R := len(s) - 1

	for L < R {

		s[L], s[R] = s[R], s[L]

		L++
		R--
	}
}
