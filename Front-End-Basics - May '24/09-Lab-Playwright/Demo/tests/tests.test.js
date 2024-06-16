const {test, expect} = require('@playwright/test');

test("Navigating to Playwright page", async ({page}) => {
    await page.goto('https://playwright.dev/');
});

test('Page has Playwright in title', async ({ page }) => {
    await page.goto('https://playwright.dev/');
    const title = await page.title();
    expect(title).toBe('Fast and reliable end-to-end testing for modern web apps | Playwright');
    const getStarted = await page.textContent('text=Get Started');
    expect(getStarted).toBeTruthy();
});