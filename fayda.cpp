#include <bits/stdc++.h>

using namespace std;

#define int long double
#define all(a) (a).begin(), (a).end()

void solve() {
    int n = 10200;
    cout << 10200 * ( (pow(1.05, 24) - 1)/ 0.05) << endl;

    int cnt = 0;
    for(int i = 0; i < 24; i++) {
        cnt += 10200 * pow(1.05, i);
    }
    cout << cnt << endl;

    

    int total = 0;
    for(int i = 0; i < 24; i++) {
        total += 10200 + total * 0.05;
    }
    cout << total << endl;
}

int32_t main() {
    ios_base::sync_with_stdio(false);
    cin.tie(nullptr);
    cout.tie(nullptr);

    int tt = 1;
    // cin >> tt;

    while (tt--) {
        solve();
    }

    return 0;
}