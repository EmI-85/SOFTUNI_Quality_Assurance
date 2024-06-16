const {test, expect} = require('@playwright/test');

// 'Test 1: Test If a User Can Add a Task'
test('User can add task', async ({page}) => {
    //arrange
    await page.goto('http://localhost:8080/');

    //act
    await page.fill('#task-input', 'Test task');
    await page.click('#add-task');

    //assert
    const taskText = await page.textContent('.task');
    expect(taskText).toContain('Test task');
});

// 'Test 2: Test If a User Can Delete a Task'
test('User can delete task', async ({page}) => {
    //arrange
    await page.goto('http://localhost:8080/');
    await page.fill('#task-input', 'Test task');
    await page.click('#add-task');

    //act
    await page.click('.task .delete-task');

    //assert
    const tasks = await page.$$eval('.task', tasks => tasks.map(
        task => task.textContent
    ));
    expect(tasks).not.toContain('Test task');
});

// 'Test 3: Test If a User Can Mark a Task as Complete'
test('User can mark task as complete', async ({page}) => {
    //arrange
    await page.goto('http://localhost:8080/');
    await page.fill('#task-input', 'Test task');
    await page.click('#add-task');

    //act
    await page.click('.task .task-complete');

    //assert
    const completedTask = await page.$('.task.completed');

    expect(completedTask).not.toBeNull;
});

// 'Test 4: Test If a User Can Filter Tasks'
test('User can filter tasks', async ({page}) => {
    //arrange
    await page.goto('http://localhost:8080/');
    await page.fill('#task-input', 'Test task');
    await page.click('#add-task');
    await page.click('.task .task-complete');

    //act
    await page.selectOption('#filter',"Completed");

    //assert
    const activeTasks = await page.$('.task:not(.completed)');

    expect(activeTasks).toBeNull;
});