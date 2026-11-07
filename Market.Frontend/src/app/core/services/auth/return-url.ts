/**
 * returnUrl: the page the user returns to after logging in (/auth/login?returnUrl=/client/profile).
 *
 * returnUrl comes from the address, and anyone can write an address (a link in an email, a message...).
 * That is why after login we go ONLY to a path inside the application; otherwise someone could
 * "return" the user to a foreign site that looks like ours (open redirect).
 *
 * Allowed:   "/client/profile", "/client/profile?tab=password"
 * Rejected:  "https://evil.com", "//evil.com", "/\evil.com", "javascript:...", "/auth/..."
 */
export function isSafeReturnUrl(url: string | null | undefined): url is string {
  if (!url) {
    return false;
  }
  return (
    url.startsWith('/') &&
    !url.startsWith('//') &&
    // browser "\" tretira kao "/" → "/\evil.com" je isto što i "//evil.com"
    !url.includes('\\') &&
    // povratak na login/logout nema smisla (i mogao bi napraviti petlju)
    !url.startsWith('/auth')
  );
}
