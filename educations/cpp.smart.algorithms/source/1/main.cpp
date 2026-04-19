#include <iostream>
#include <vector>
#include <string>
#include <algorithm>
using namespace std;

// Calculation of the distance between the two strings
int levenshteinDistance(const string& s1, const string& s2) {
	int m = s1.length();
	int n = s2.length();

	vector<vector<int>> dp(m + 1, vector<int>(n + 1, 0));

	for (int i = 0; i <= m; ++i) {
		for (int j = 0; j <= n; ++j) {
			if (i == 0)
				dp[i][j] = j;
			else if (j == 0)
				dp[i][j] = i;
			else if (s1[i - 1] == s2[j - 1])
				dp[i][j] = dp[i - 1][j - 1];
			else
				dp[i][j] = 1 + min({dp[i - 1][j], dp[i][j - 1], dp[i - 1][j - 1]});
		}
	}

	return dp[m][n];
}

int main() {
	vector<string> texts = {"apple", "banana", "cherry", "date", "fig"};
	while(true)
	{
		string input;
		char answer;
		cout << "Enter a text: ";
		cin >> input;
    	
		// Find the nearest text
		int minDistance = INT_MAX;
		string closestText;
		for (const auto& text : texts) {
			int distance = levenshteinDistance(input, text);
			if (distance < minDistance) {
				minDistance = distance;
				closestText = text;
			}
		}

		cout << "Closest text: " << closestText << endl;

		// Perform a function related to the closest text (e.g. a function that does sorting)
		// Here is not an example of the sort function, but you can add your own sort function.
		
		cout << "Do you want to continue(y|n)? ";
		cin >> answer;
		if (answer == 'n') break;
		else continue;
	}
	cout << "Goodbye.";
}